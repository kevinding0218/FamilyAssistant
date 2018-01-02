import { NgModule } from '@angular/core';
import { MealRoutingModule } from './meal-routing.module';
import { VegetableListComponent } from './vegetable/vegetable-list/vegetable-list.component';
import { VegetableFormComponent } from './vegetable/vegetable-form/vegetable-form.component';
import { VegetableService } from './../../services/meal/vegetable/vegetable.service';

@NgModule({
  imports: [ MealRoutingModule ],
  declarations: [
    VegetableListComponent,
    VegetableFormComponent
  ],
  providers: [ VegetableService ]
})
export class MealModule { }
