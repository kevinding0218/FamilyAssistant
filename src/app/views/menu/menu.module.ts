import { NgModule } from '@angular/core';
import { VegetableListComponent } from './vegetable/vegetable-list.component';
import { MenuRoutingModule } from './menu-routing.module';

@NgModule({
  imports: [ MenuRoutingModule ],
  declarations: [
    VegetableListComponent
  ]
})
export class MenusModule { }
