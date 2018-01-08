import { VegetableService } from './../../../../services/meal/vegetable/vegetable.service';
import { SaveVegetable, KeyValuePairInfo } from './../../../../viewModels/meal/vegetable';
import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

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
    private _vegetableService: VegetableService,
    private toastr: ToastrService
  ) { }

  ngOnInit() {
    
  }

  submit() {  
     this._vegetableService.create(this.vegetable)
      .subscribe(
        x => console.log(x),
        err => {
          this.toastr.error('Error!', 'An unexpected error happened!');
        }
      ); 
  }

  getVegetable() {
    this._vegetableService.getVegetable(5)
      .subscribe(x => console.log(x));
  }

}
