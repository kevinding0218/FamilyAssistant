import { SaveVegetable } from './../../viewModels/meal/vegetable';
import { SharedServiceHelper } from './../event/shared.service.helper';
import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';


@Injectable()
export class VegetableService {
  private readonly serviceApiEndPoint: string = 'http://localhost:62657/api/vegetable';
  private readonly debugApiEndPoint: string = 'http://localhost:5000/api/vegetable';
  private isDebug: boolean = false;
  private readonly apiEndPoint: string = this.isDebug ? this.debugApiEndPoint : this.serviceApiEndPoint;
  constructor(private _http: Http) { }

  getVegetable(id) {
    return this._http.get(this.apiEndPoint + '/' + id)
      .map(res => res.json());
  }

  create(vegetable: SaveVegetable) {
    console.log('In Create');
    console.log(vegetable);
    return this._http.post(this.apiEndPoint, vegetable)
      .map(res => res.json());
  }

  update(vegetable: SaveVegetable) {
    return this._http.put(this.apiEndPoint + '/' + vegetable.keyValuePairInfo.id, vegetable)
      .map(res => res.json());
  }

  delete(id) {
    return this._http.delete(this.apiEndPoint + '/' + id)
      .map(res => res.json());
  }

  getVegetables(filter) {
    return this._http.get(this.apiEndPoint + '?' + SharedServiceHelper.toQueryString(filter))
      .map(res => res.json());
  }
}
