import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
//Object Component
import { AppComponent } from './app.component';
import { VegetableComponent } from "./vegetable/vegetable.component";
import { DashboardComponent } from "./dashboard/dashboard.component";

// Import Containers
import {
  FullLayoutComponent,
  SimpleLayoutComponent
} from './containers';


const routes: Routes = [
  { path: 'home', component: DashboardComponent },
  { path: 'vegetable', component: VegetableComponent },
  {
    path: '',
    redirectTo: 'dashboard',
    pathMatch: 'full',
  },
  {
    path: '',
    component: FullLayoutComponent,
    data: {
      title: 'Home'
    },
    children: [
      {
        path: 'dashboard',
        loadChildren: './views/dashboard/dashboard.module#DashboardModule'
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
