import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class ManagerService {
  private baseURL = "http://localhost:44345";
  tz: string = "123456789";
  

  getBusLines(controller, StopNum) {
    // return this.httpClient.get(`${this.baseURL}/api/${controller}/${StopNum}`)
    // var obs: Observable<any> = this.httpClient.get(`${ this.baseURL } / api / ${ controller } / ${ StopNum }`, { responseType: 'text' })
    var obs: Observable<any> = this.httpClient.get(`https://localhost:44345/api/lines/131`, { responseType: 'text' })

    return obs;
  }

  constructor(private r: Router, private httpClient: HttpClient) { }
}
