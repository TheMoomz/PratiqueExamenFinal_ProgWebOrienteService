import { Picture } from "./picture";

export class Tweet{
    constructor(public id : number, public text : string, public score : number, public picture : Picture | null){}
}