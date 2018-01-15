"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var ngx_toastr_1 = require("ngx-toastr");
var http_1 = require("@angular/http");
var core_1 = require("@angular/core");
var forms_1 = require("@angular/forms");
var platform_browser_1 = require("@angular/platform-browser");
var animations_1 = require("@angular/platform-browser/animations");
var core_2 = require("@angular/core");
var common_1 = require("@angular/common");
var app_error_handler_1 = require("./eventHandler/app.error-handler");
//Routing
var app_routing_module_1 = require("./app-routing.module");
//App Component
var app_component_1 = require("./app.component");
// Import containers
var containers_1 = require("./containers");
var APP_CONTAINERS = [
    containers_1.FullLayoutComponent,
    containers_1.SimpleLayoutComponent
];
// Import components
var components_1 = require("./components");
var APP_COMPONENTS = [
    components_1.AppAsideComponent,
    components_1.AppBreadcrumbsComponent,
    components_1.AppFooterComponent,
    components_1.AppHeaderComponent,
    components_1.AppSidebarComponent,
    components_1.AppSidebarFooterComponent,
    components_1.AppSidebarFormComponent,
    components_1.AppSidebarHeaderComponent,
    components_1.AppSidebarMinimizerComponent,
    components_1.APP_SIDEBAR_NAV
];
// Import directives
var directives_1 = require("./directives");
var error_log_service_1 = require("./services/event/error.log.service");
var APP_DIRECTIVES = [
    directives_1.AsideToggleDirective,
    directives_1.NAV_DROPDOWN_DIRECTIVES,
    directives_1.ReplaceDirective,
    directives_1.SIDEBAR_TOGGLE_DIRECTIVES
];
var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        core_2.NgModule({
            declarations: [
                app_component_1.AppComponent
            ].concat(APP_CONTAINERS, APP_COMPONENTS, APP_DIRECTIVES),
            imports: [
                platform_browser_1.BrowserModule,
                animations_1.BrowserAnimationsModule,
                forms_1.FormsModule,
                http_1.HttpModule,
                app_routing_module_1.AppRoutingModule,
                ngx_toastr_1.ToastrModule.forRoot({
                    timeOut: 3000,
                    positionClass: 'toast-top-right',
                    closeButton: true,
                    progressAnimation: 'increasing'
                })
            ],
            providers: [
                {
                    provide: common_1.LocationStrategy,
                    useClass: common_1.HashLocationStrategy
                },
                {
                    provide: core_1.ErrorHandler,
                    useClass: app_error_handler_1.AppErrorHandler
                },
                error_log_service_1.ErrorLogService
            ],
            bootstrap: [app_component_1.AppComponent]
        })
    ], AppModule);
    return AppModule;
}());
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map