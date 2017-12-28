import { HttpModule } from '@angular/http';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
//Utility
import { AppRoutingModule } from './app-routing.module';
import { AppNgxBootstrapModule } from "./module/app-ngx-bootstrap.module";
import { AppNavMenuModule } from './module/app-nav-menu.module';
//Object Component
import { AppComponent } from './app.component';

import { VegetableComponent } from './vegetable/vegetable.component';
import { DashboardComponent } from './dashboard/dashboard.component';




@NgModule({
  declarations: [
    AppComponent,
    VegetableComponent,
    DashboardComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    AppRoutingModule,
    AppNgxBootstrapModule,
    AppNavMenuModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
