import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { from, Observable } from 'rxjs';
import { Draft } from 'src/app/Classes/draft';
import { Email } from 'src/app/Classes/email';
import { Inbox } from 'src/app/Classes/inbox';
import { Sent } from 'src/app/Classes/sent';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class UserManagerService {

  constructor(private r: Router, private httpClient: HttpClient) { }

  private baseURL = "http://localhost:63673";

  user: string;
  displayedEmail: Email;
  toOrFrom: string;
  name: string;
  type: string;
  get(controller, email, password) {
    var obs :Observable<any> = this.httpClient.get(`${this.baseURL}/api/${controller}/${email}/${password}`,{ responseType: 'text' })
    // return this.httpClient.get(`${this.baseURL}/api/${controller}/${email}/${password}`)
    return obs;
  }
  getEmailList(controller, parameter) {
    return this.httpClient.get(`${this.baseURL}/api/${controller}/${parameter}`)
  }

  displayEmail(displayEmail) {
    this.displayedEmail = displayEmail;
    let routeArray = window.location.href.split("/");
    this.type = routeArray[routeArray.length - 1];
    if(this.type == "inbox"){
      this.toOrFrom = "from";
      this.name = (this.displayedEmail as Inbox).from;
    }
    if(this.type == "draft"){
      this.toOrFrom = "to";
      this.name = (this.displayedEmail as Draft).to;
    }
    if(this.type == "sent"){
      this.toOrFrom = "to";
      this.name = (this.displayedEmail as Sent).to;
    }
    this.r.navigate([`/home/${this.user}/details`]);
  }
}
