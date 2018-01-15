"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var common_1 = require("@angular/common");
var router_1 = require("@angular/router");
var nav_menu_header_component_1 = require("../navmenu/nav-menu-header/nav-menu-header.component");
var nav_menu_top_link_component_1 = require("../navmenu/nav-menu-top-link/nav-menu-top-link.component");
var nav_menu_side_bar_component_1 = require("../navmenu/nav-menu-side-bar/nav-menu-side-bar.component");
var navmenu_component_1 = require("../navmenu/navmenu.component");
var AppNavMenuModule = /** @class */ (function () {
    function AppNavMenuModule() {
    }
    AppNavMenuModule = __decorate([
        core_1.NgModule({
            declarations: [
                nav_menu_header_component_1.NavMenuHeaderComponent,
                nav_menu_top_link_component_1.NavMenuTopLinkComponent,
                nav_menu_side_bar_component_1.NavMenuSideBarComponent,
                navmenu_component_1.NavMenuComponent
            ],
            imports: [
                common_1.CommonModule,
                router_1.RouterModule
            ],
            exports: [
                navmenu_component_1.NavMenuComponent
            ]
        })
    ], AppNavMenuModule);
    return AppNavMenuModule;
}());
exports.AppNavMenuModule = AppNavMenuModule;
//# sourceMappingURL=app-nav-menu.module.js.map