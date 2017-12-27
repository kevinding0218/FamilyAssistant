import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
//Object Component
import { AppComponent } from './app.component';
import { VegetableComponent } from "./vegetable/vegetable.component";
import { DashboardComponent } from "./dashboard/dashboard.component";

const routes: Routes = [
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'home', component: DashboardComponent },
  { path: 'vegetable', component: VegetableComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
