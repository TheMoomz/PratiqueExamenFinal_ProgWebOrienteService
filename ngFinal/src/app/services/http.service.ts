import { HttpClient } from '@angular/common/http';
import { ElementRef, Injectable } from '@angular/core';
import { lastValueFrom, throwIfEmpty } from 'rxjs';
import { LoginDTO } from 'src/app/models/loginDTO';
import { RegisterDTO } from 'src/app/models/registerDTO';
import { Tweet } from 'src/app/models/tweet';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  // Liste des Tweets principaux
  tweets : Tweet[] = [];

  // Liste des Tweets qui sont des réponses au dernier Tweet sélectionné par l'utilisateur
  subTweets : Tweet[] = [];

  constructor(public http : HttpClient) { }

  // Inscription
  async register(registerDTO : RegisterDTO):Promise<void>{
    let request = await lastValueFrom(this.http.post<any>("http://localhost:5265/api/users/register", registerDTO));
    console.log(request);
  }

  // Connexion
  async login(loginDTO : LoginDTO):Promise<void>{
    let request = await lastValueFrom(this.http.post<any>("http://localhost:5265/api/users/login", loginDTO));
    console.log(request);
    localStorage.setItem("token", request.token);
  }

  // Obtenir les tweets principaux
  async getMainTweets() : Promise<void>{
    console.log("Obtention des tweets principaux...");
    let response = await lastValueFrom(this.http.get<Tweet[]>("http://localhost:5265/api/tweets/gettweets"));
    this.tweets = response;
    console.log(response);
  }

  // Obtenir les sous-tweets (réponses) d'un tweet principal
  async getSubTweets(id : number) : Promise<void>{
    // id -> id du tweet principal dont on souhaite récupérer les réponses (sous-tweets)
    let res = await lastValueFrom(this.http.get<Tweet[]>('http://localhost:5265/api/tweets/getsubtweets/' + id))
    console.log(res);
    this.subTweets = res;
  }

  // Créer un nouveau tweet principal
  async postTweet(text : string, tweetImage ?: ElementRef) : Promise<void>{
    let newTweet = new Tweet(0, text, 0, null);
    let response = await lastValueFrom(this.http.post<Tweet>("http://localhost:5265/api/tweets/posttweet", newTweet));
    console.log(response);
    if(tweetImage != undefined && tweetImage.nativeElement.files.length > 0){
      let file = tweetImage.nativeElement.files[0];
      let formData = new FormData();
      formData.append("image", file, file.name);

      let response2 = await lastValueFrom(this.http.post<any>("http://localhost:5265/api/pictures/postpicture/" + response.id, formData));
      console.log(response2);
    }
    this.getMainTweets();
  }

  // Ajouter un sous-tweet (réponse) à un tweet principal
  async postSubTweet(text : string, mainTweetId : number) : Promise<void>{
    let newTweet = new Tweet(0, text, 0, null);
    let response = await lastValueFrom(this.http.post<Tweet>("http://localhost:5265/api/tweets/postsubtweet/" + mainTweetId, newTweet));
    console.log(response);
    this.getSubTweets(mainTweetId);
  }

  // +1 (upvote)
  async upvoteTweet(tweet : Tweet) : Promise<void>{

    let response = await lastValueFrom(this.http.put<Tweet>('http://localhost:5265/api/tweets/changevote/' + tweet.id + '/' +  1, 1));
    // À compléter

    console.log(response);
    this.getMainTweets();

  }

  // -1 (downvote)
  async downvoteTweet(tweet : Tweet) : Promise<void>{

    let response = await lastValueFrom(this.http.put<Tweet>('http://localhost:5265/api/tweets/changevote/' + tweet.id + '/' + -1, -1));
    // À compléter
    console.log(response);
    this.getMainTweets();

  }

  // Supprimer un tweet
  async deleteTweet(id : number) : Promise<void>{
    await lastValueFrom(this.http.delete<Tweet>("http://localhost:5265/api/tweets/delete/" + id));
  }

}
