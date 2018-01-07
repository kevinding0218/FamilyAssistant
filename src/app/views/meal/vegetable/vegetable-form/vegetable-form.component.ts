import { VegetableService } from './../../../../services/meal/vegetable/vegetable.service';
import { SaveVegetable, KeyValuePairInfo } from './../../../../viewModels/meal/vegetable';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-vegetable-form',
  templateUrl: './vegetable-form.component.html'
})
export class VegetableFormComponent implements OnInit {
  vegetable: any = { 
    keyValuePairInfo: {
      id: 0,
      name: ''
    }
  };

  constructor(
    private _vegetableService: VegetableService
  ) { }

  ngOnInit() {
    
  }

  submit() {
    this._vegetableService.create(this.vegetable)
      .subscribe(x => console.log(x));
  }

  getVegetable() {
    this._vegetableService.getVegetable(5)
      .subscribe(x => console.log(x));
  }

}
