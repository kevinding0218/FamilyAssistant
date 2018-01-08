import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class VegetableService {
  apiHost : string = 'http://localhost:62657/api/vegetable';
  constructor(private _http: Http) { } 

  getVegetable(id) {
    return this._http.get(this.apiHost + '/' + id)
      .map(res => res.json());
  }

  create(vegetable) {
    return this._http.post(this.apiHost, vegetable)
      .map(res => res.json());
  }
}
