using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using finalServeur.Data;
using finalServeur.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;

namespace finalServeur.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class TweetsController : ControllerBase
    {
        private readonly finalServeurContext _context;

        public TweetsController(finalServeurContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<Tweet> GetTweets()
        {
            List<Tweet> tweets = _context.Tweet.Where(t => t.AnswerTo == null).ToList();
            return tweets;
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<Tweet>>> GetSubTweets(int id)
        {
            Tweet mainTweet = await _context.Tweet.FindAsync(id);
            return mainTweet.Answers;
        }

        [HttpPost]
        public async Task<ActionResult<Tweet>> PostTweet(Tweet tweet)
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            User user = _context.Users.Single(u => u.Id == userId);

            if(user == null)
            {
                return StatusCode(401, new { Message = "Please log in." });
            }


            tweet.Text += Environment.NewLine + "-" + user.UserName;

            tweet.User = user;
            
            user.Tweets.Add(tweet);

            _context.Tweet.Add(tweet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("PostTweet", new { id = tweet.Id }, tweet);
        }

        [HttpPost("{id}")]
        public async Task<ActionResult<Tweet>> PostSubTweet(int id, Tweet tweet)
        {
            Tweet mainTweet = await _context.Tweet.FindAsync(id);
            if (mainTweet == null)
            {
                return NotFound();
            }

            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            User user = _context.Users.Single(u => u.Id == userId);

            tweet.Text += Environment.NewLine + "-" + user.UserName;

            tweet.User = user;
            user.Tweets.Add(tweet);
            tweet.AnswerTo = mainTweet;
            mainTweet.Answers.Add(tweet);

            _context.Tweet.Add(tweet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("PostSubTweet", new { id = tweet.Id }, tweet);
        }

        [HttpPut("{id}/{value}")]
        [AllowAnonymous]
        public async Task<ActionResult<Tweet>> ChangeVote(int id, int value)
        {
            Tweet tweetChange = await _context.Tweet.SingleAsync(t => t.Id == id);

            tweetChange.Score += value;

            _context.Entry(tweetChange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                if(!await _context.Tweet.AnyAsync(x => x.Id == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }


            return Ok(new {Message = "Vote changed."});
        }

        [HttpDelete("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> DeleteTweet(int id)
        {
            Tweet tweet = await _context.Tweet.FindAsync(id);
            if (tweet == null)
            {
                return NotFound();
            }

            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            User user = _context.Users.Single(u => u.Id == userId);

            if(tweet.User.Id != user.Id)
            {
                return BadRequest();
            }

            user.Tweets.Remove(tweet);
            tweet.User = null;

            _context.Tweet.Remove(tweet);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
