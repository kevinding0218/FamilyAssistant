import { MeatService } from './../../services/meal/meat.service';
import { MeatFormComponent } from './meat/meat-form/meat-form.component';
import { AppNgxBootstrapModule } from './../../ngxModule/app-ngx-bootstrap.module';
import { PaginationComponent } from './../../components/table-pagination/pagination.component';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { MealRoutingModule } from './meal-routing.module';
import { VegetableListComponent } from './vegetable/vegetable-list/vegetable-list.component';
import { VegetableFormComponent } from './vegetable/vegetable-form/vegetable-form.component';
import { VegetableService } from './../../services/meal/vegetable.service';
import { MeatListComponent } from './meat/meat-list/meat-list.component';

@NgModule({
  imports: [ FormsModule, CommonModule, MealRoutingModule, AppNgxBootstrapModule ],
  declarations: [
    VegetableListComponent,
    VegetableFormComponent,
    PaginationComponent,
    MeatListComponent,
    MeatFormComponent
  ],
  providers: [ VegetableService, MeatService ]
})
export class MealModule { }
