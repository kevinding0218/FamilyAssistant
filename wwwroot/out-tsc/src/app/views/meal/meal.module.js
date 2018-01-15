"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var meat_service_1 = require("./../../services/meal/meat.service");
var meat_form_component_1 = require("./meat/meat-form/meat-form.component");
var app_ngx_bootstrap_module_1 = require("./../../ngxModule/app-ngx-bootstrap.module");
var pagination_component_1 = require("./../../components/table-pagination/pagination.component");
var core_1 = require("@angular/core");
var forms_1 = require("@angular/forms");
var common_1 = require("@angular/common");
var meal_routing_module_1 = require("./meal-routing.module");
var vegetable_list_component_1 = require("./vegetable/vegetable-list/vegetable-list.component");
var vegetable_form_component_1 = require("./vegetable/vegetable-form/vegetable-form.component");
var vegetable_service_1 = require("./../../services/meal/vegetable.service");
var meat_list_component_1 = require("./meat/meat-list/meat-list.component");
var MealModule = /** @class */ (function () {
    function MealModule() {
    }
    MealModule = __decorate([
        core_1.NgModule({
            imports: [forms_1.FormsModule, common_1.CommonModule, meal_routing_module_1.MealRoutingModule, app_ngx_bootstrap_module_1.AppNgxBootstrapModule],
            declarations: [
                vegetable_list_component_1.VegetableListComponent,
                vegetable_form_component_1.VegetableFormComponent,
                pagination_component_1.PaginationComponent,
                meat_list_component_1.MeatListComponent,
                meat_form_component_1.MeatFormComponent
            ],
            providers: [vegetable_service_1.VegetableService, meat_service_1.MeatService]
        })
    ], MealModule);
    return MealModule;
}());
exports.MealModule = MealModule;
//# sourceMappingURL=meal.module.js.map