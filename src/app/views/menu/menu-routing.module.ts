import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { VegetableListComponent } from './vegetable/vegetable-list.component';

const routes: Routes = [
  {
    path: '',
    data: {
      title: 'Menu'
    },
    children: [
      {
        path: 'vegetables',
        component: VegetableListComponent,
        data: {
          title: 'Vegetables'
        }
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MenuRoutingModule {}
