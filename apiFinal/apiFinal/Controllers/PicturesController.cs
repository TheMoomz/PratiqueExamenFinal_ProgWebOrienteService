using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using finalServeur.Data;
using finalServeur.Models;
using SixLabors.ImageSharp;
using System.IO;
using SixLabors.ImageSharp.Processing;

namespace finalServeur.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PicturesController : ControllerBase
    {
        private readonly finalServeurContext _context;

        public PicturesController(finalServeurContext context)
        {
            _context = context;
        }

        // GET: api/Pictures/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Picture>> GetPicture(int id)
        {
            Picture picture = await _context.Picture.FindAsync(id);

            if (picture == null)
            {
                return NotFound();
            }

            byte[] bytes = System.IO.File.ReadAllBytes(Directory.GetCurrentDirectory() + "/images/" + picture.FileName);

            return File(bytes, picture.MimeType);
        }

        // POST: api/Pictures
        [HttpPost("{id}")]
        public async Task<ActionResult<Picture>> PostPicture(int id) // id = TweetId
        {
            try
            {
                IFormCollection formCollection = await Request.ReadFormAsync();
                IFormFile file = formCollection.Files.GetFile("image");
                Image image = Image.Load(file.OpenReadStream());

                Picture picture = new Picture();
                picture.FileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                picture.MimeType = file.ContentType;

                Tweet tweetAssoc = await _context.Tweet.SingleAsync(t => t.Id == id);

                picture.Tweet = tweetAssoc;

                image.Mutate(i =>
                    i.Resize(new ResizeOptions()
                    {
                        Mode = ResizeMode.Min,
                        Size = new Size() { Height = 160 }
                    })
                );
                image.Save(Directory.GetCurrentDirectory() + "/images/" + picture.FileName);

                _context.Picture.Add(picture);
                await _context.SaveChangesAsync();
            }
            catch (Exception e) {}
            return Ok(new {Message = "Photo enregistrée sur le serveur !"});
        }

    }
}
