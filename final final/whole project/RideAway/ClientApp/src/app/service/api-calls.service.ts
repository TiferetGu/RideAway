import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
 import { HttpParams } from '@angular/common/http';
 import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class ApiCallsService {

  constructor(private http: HttpClient) { }
  getWeather(location: any){
    debugger
    return this.http.get(
        'http://dataservice.accuweather.com/locations/v1/cities/autocomplete?apikey=cXkrHCX30tCGDx9cqXAhOlhZtUt60uAt&q=' + location
    );
    }
    getWeather1(lat: number, lng: number): Observable<any>{
      debugger
      return this.http.get(
          'http://dataservice.accuweather.com/currentconditions/v1/locationKey?apikey=cXkrHCX30tCGDx9cqXAhOlhZtUt60uAt%26q%3Dtel-%20aviv&details=true'+lat+lng
      );
    }

  // getRequest(url:string, q?:any) {
  //   const params = new HttpParams({fromObject: {
  //     apikey:'http://dataservice.accuweather.com/currentconditions/v1/locationKey?apikey=cXkrHCX30tCGDx9cqXAhOlhZtUt60uAt%26q%3Dtel-%20aviv&details=true'
  //   , q}});
  //   return this.http.get(url, {params});

  // }

  // getGeoPosition(lat: number, lng: number): Observable<any> {
  //   const url = `http://dataservice.accuweather.com/locations/v1/cities/geoposition/search`;
  //   return this.getRequest(url, `${lat},${lng}`);
  // }

  // getAutoComplete(key: string): Observable<any> {
  //   const url = `http://dataservice.accuweather.com/locations/v1/cities/autocomplete`;
  //   return this.getRequest(url, `${key}`);
  // }

  // get5DaysOfForecasts(key: string): Observable<any> {
  //   const url = `http://dataservice.accuweather.com/forecasts/v1/daily/5day/${key}`;
  //   return this.getRequest(url);
  // }


  // getCurrentConditions(key: string): Observable<any> {
  //   const url = `http://dataservice.accuweather.com/currentconditions/v1/${key}`;
  //   return this.getRequest(url);
  // }
 }
