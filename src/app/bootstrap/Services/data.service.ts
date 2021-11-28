import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders } from '@angular/common/http';
import { BusLines } from 'src/app/BusLines';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(private http : HttpClient) { }
    _baseUrl: string = "http://localhost:51712/"
    httpOptions = {
      headers: new HttpHeaders({
        'accept': 'application/json'
      })
    }

 public busLines= [
   new BusLines(31),
   new BusLines(32),
   new BusLines(36),
   new BusLines(37),
   new BusLines(63),
   new BusLines(64),
   new BusLines(71),
   new BusLines(72)
 ]

    getPassengers(){
      var res = this.http.get(`${this._baseUrl}api/passenger/get`,{
        headers:{"accept": "application/json"},
      });
      return res;
    }

    getPassengersById(id){
      var res = this.http.get(`${this._baseUrl}api/passenger/get/${id}`,{
        headers:{"accept": "application/json"},
      });
      return res;
    }

    AddWaitingPassenger(passenger){
      var res = this.http.post(`${this._baseUrl}api/passenger/post/${passenger}`,{
        headers:{"accept": "application/json"},
      });
      return res;
    }

    getReasonsOfDealy(){
      var res = this.http.get(`${this._baseUrl}api/passenger/get`,{
        headers:{"accept": "application/json"},
      });
      return res;
    }

}
