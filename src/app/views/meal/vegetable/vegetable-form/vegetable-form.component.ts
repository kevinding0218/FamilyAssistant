import { NgForm } from '@angular/forms/src/directives';
import { Observable } from 'rxjs/Rx';
import { ActivatedRoute, Router } from '@angular/router';
import { VegetableService } from './../../../../services/meal/vegetable/vegetable.service';
import { SaveVegetable, KeyValuePairInfo } from './../../../../viewModels/meal/vegetable';
import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-vegetable-form',
  templateUrl: './vegetable-form.component.html'
})
export class VegetableFormComponent implements OnInit {
  vegetable: SaveVegetable = {
    keyValuePairInfo: {
      id: null,
      name: ''
    },
    addedOn: null,
    addedByUserId: null,
    updatedOn: null,
    lastUpdatedByUserId: null
  };

  constructor(
    private _route: ActivatedRoute,
    private _router: Router,
    private _vegetableService: VegetableService,
    private toastr: ToastrService
  ) {
    _route.params.subscribe(p => {
      this.vegetable.keyValuePairInfo.id = (typeof p['id'] == 'undefined') ? 0 : +p['id'];
    });
  }

  ngOnInit() {
    var sources = [];

    if (this.vegetable.keyValuePairInfo.id)
      sources.push(this._vegetableService.getVegetable(this.vegetable.keyValuePairInfo.id));

    Observable.forkJoin(sources).subscribe(data => {
      if (this.vegetable.keyValuePairInfo.id) {
        this.setVegetable(data[0]);
      }
    }, err => {
      if (err.status == 404)
        this._router.navigate(['/pages/404']);
    });
  }

  private setVegetable(vege: any) {
    this.vegetable.keyValuePairInfo.name = vege.keyValuePairInfo.name;
    this.vegetable.addedOn = vege.addedOn;
    this.vegetable.addedByUserId = vege.addedByUserId;
    this.vegetable.updatedOn = vege.updatedOn;
    this.vegetable.lastUpdatedByUserId = vege.lastUpdatedByUserId;
  }

  submit() {
    if (this.vegetable.keyValuePairInfo.id) {
      this.vegetable.lastUpdatedByUserId = 1;

      this._vegetableService.update(this.vegetable)
        .subscribe(x => {
          this.toastr.success('This vegetable has been successfully updated!', 'UPDATE SUCCESS');
        });
    } else {
      this.vegetable.addedByUserId = 1;
      this.vegetable.addedOn = new Date();
      this._vegetableService.create(this.vegetable)
        .subscribe(x => {
          this.toastr.success('This vegetable has been successfully inserted!', 'INSERT SUCCESS');
        });
    }
  }

  checkFormValue(f: NgForm) {
    console.log(f.value);  // { first: '', last: '' }
    console.log(f.valid);  // false
  }

  deleteVegetable() {
    if (confirm("Are you sure?")) {
      // this._vegetableService.delete(this.vegetable.keyValuePairInfo.id)
      //     .subscribe(x => {
      //         this._router.navigate(['/meal/vegetableForm/new']);
      //     });
    }
  }

}
