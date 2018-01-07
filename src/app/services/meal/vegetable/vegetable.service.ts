import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class VegetableService {

  constructor(private _http: Http) { } 

  getVegetable(id) {
    return this._http.get('http://localhost:62657/api/vegetable/' + id)
      .map(res => res.json());
  }

  create(vegetable) {
    return this._http.post('/api/vegetable', vegetable)
      .map(res => res.json());
  }
}
