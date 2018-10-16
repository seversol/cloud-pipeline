import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from '../environments/environment';


@Injectable({
  providedIn: 'root'
})
export class StationService {

  _apiUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  public getStations(address?:string, fuelType?:string) {
    let params = new HttpParams();
    
    if(address) {
      params = params.append('address', address);
    }

    if(fuelType) {
      params = params.append('fuelType', fuelType);
    }

    return this.http.get(this._apiUrl, {params: params});
  }
  
}
