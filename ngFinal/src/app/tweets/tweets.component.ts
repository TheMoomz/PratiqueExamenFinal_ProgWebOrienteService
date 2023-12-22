import { Tweet } from '../models/tweet';
import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { HttpService } from 'src/app/services/http.service';

@Component({
  selector: 'app-tweets',
  templateUrl: './tweets.component.html',
  styleUrls: ['./tweets.component.css']
})
export class TweetsComponent implements OnInit {

  displayNewTweetBox : boolean = false;
  newTweetText : string = "";
  newSubTweetText : string = "";
  charLimit : number = 200;
  subCharLimit : number = 200;
  chosenTweet : number = 0;

  @ViewChild("tweetImage", {static:false}) tweetImage ?: ElementRef;

  constructor(public httpService : HttpService) { }

  ngOnInit() {
    this.httpService.getMainTweets();
  }

  createTweet(tweetText : string) : void {
    this.httpService.postTweet(tweetText, this.tweetImage);
  }

  openSubTweets(id : number) : void{
    this.chosenTweet = id;
    this.httpService.getSubTweets(id);
  }

  displayNewTweet() : void{
    this.displayNewTweetBox = !this.displayNewTweetBox;
  }

  updateLimit() : void{
    this.charLimit = 200 - this.newTweetText.length;
  }
  updateSubLimit() : void{
    this.subCharLimit = 200 - this.newSubTweetText.length;
  }

}
