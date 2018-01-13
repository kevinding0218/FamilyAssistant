import { MeatListComponent } from './meat/meat-list/meat-list.component';
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
        path: '',
        component: VegetableListComponent,
        data: {
          title: 'Vegetables'
        }
      },
      {
        path: 'vegetableList',
        component: VegetableListComponent,
        data: {
          title: 'Vegetables'
        }
      },
      {
        path: 'vegetableForm/new',
        component: VegetableFormComponent,
        data: {
          title: 'New Vegetable'
        }
      },
      {
        path: 'vegetableForm/:id',
        component: VegetableFormComponent,
        data: {
          title: 'New Vegetable'
        }
      },
      {
        path: 'meatList',
        component: MeatListComponent,
        data: {
          title: 'Meats'
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
