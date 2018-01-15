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
var dropdown_1 = require("ngx-bootstrap/dropdown");
var tooltip_1 = require("ngx-bootstrap/tooltip");
var modal_1 = require("ngx-bootstrap/modal");
var ngx_datatable_1 = require("@swimlane/ngx-datatable");
var AppNgxBootstrapModule = /** @class */ (function () {
    function AppNgxBootstrapModule() {
    }
    AppNgxBootstrapModule = __decorate([
        core_1.NgModule({
            imports: [
                common_1.CommonModule,
                dropdown_1.BsDropdownModule.forRoot(),
                tooltip_1.TooltipModule.forRoot(),
                modal_1.ModalModule.forRoot(),
                ngx_datatable_1.NgxDatatableModule
            ],
            exports: [dropdown_1.BsDropdownModule, tooltip_1.TooltipModule, modal_1.ModalModule, ngx_datatable_1.NgxDatatableModule]
        })
    ], AppNgxBootstrapModule);
    return AppNgxBootstrapModule;
}());
exports.AppNgxBootstrapModule = AppNgxBootstrapModule;
//# sourceMappingURL=app-ngx-bootstrap.module.js.map