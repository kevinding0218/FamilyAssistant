"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var meat_form_component_1 = require("./meat/meat-form/meat-form.component");
var meat_list_component_1 = require("./meat/meat-list/meat-list.component");
var core_1 = require("@angular/core");
var router_1 = require("@angular/router");
var vegetable_list_component_1 = require("./vegetable/vegetable-list/vegetable-list.component");
var vegetable_form_component_1 = require("./vegetable/vegetable-form/vegetable-form.component");
var routes = [
    {
        path: '',
        data: {
            title: 'Meal'
        },
        children: [
            {
                path: '',
                component: vegetable_list_component_1.VegetableListComponent,
                data: {
                    title: 'Vegetables'
                }
            },
            {
                path: 'vegetableList',
                component: vegetable_list_component_1.VegetableListComponent,
                data: {
                    title: 'Vegetable List'
                }
            },
            {
                path: 'vegetableForm/new',
                component: vegetable_form_component_1.VegetableFormComponent,
                data: {
                    title: 'Create New Vegetable'
                }
            },
            {
                path: 'vegetableForm/:id',
                component: vegetable_form_component_1.VegetableFormComponent,
                data: {
                    title: 'Update Vegetable'
                }
            },
            {
                path: 'meatList',
                component: meat_list_component_1.MeatListComponent,
                data: {
                    title: 'Meat List'
                }
            },
            {
                path: 'meatForm/new',
                component: meat_form_component_1.MeatFormComponent,
                data: {
                    title: 'Create New Meat'
                }
            },
            {
                path: 'meatForm/:id',
                component: meat_form_component_1.MeatFormComponent,
                data: {
                    title: 'Update Vegetable'
                }
            }
        ]
    }
];
var MealRoutingModule = /** @class */ (function () {
    function MealRoutingModule() {
    }
    MealRoutingModule = __decorate([
        core_1.NgModule({
            imports: [router_1.RouterModule.forChild(routes)],
            exports: [router_1.RouterModule]
        })
    ], MealRoutingModule);
    return MealRoutingModule;
}());
exports.MealRoutingModule = MealRoutingModule;
//# sourceMappingURL=meal-routing.module.js.map