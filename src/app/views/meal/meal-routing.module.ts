import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { VegetableListComponent } from './vegetable/vegetable-list/vegetable-list.component';
import { VegetableFormComponent } from './vegetable/vegetable-form/vegetable-form.component';

const routes: Routes = [
  {
    path: '',
    data: {
      title: 'Meal'
    },
    children: [
      {
        path: 'vegetableList',
        component: VegetableListComponent,
        data: {
          title: 'Vegetables'
        }
      },
      {
        path: 'vegetableForm',
        component: VegetableFormComponent,
        data: {
          title: 'New Vegetable'
        }
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MealRoutingModule {}
