import { PaginationComponent } from './../../components/table-pagination/pagination.component';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { MealRoutingModule } from './meal-routing.module';
import { VegetableListComponent } from './vegetable/vegetable-list/vegetable-list.component';
import { VegetableFormComponent } from './vegetable/vegetable-form/vegetable-form.component';
import { VegetableService } from './../../services/meal/vegetable/vegetable.service';

@NgModule({
  imports: [ FormsModule, CommonModule, MealRoutingModule ],
  declarations: [
    VegetableListComponent,
    VegetableFormComponent,
    PaginationComponent
  ],
  providers: [ VegetableService ]
})
export class MealModule { }
