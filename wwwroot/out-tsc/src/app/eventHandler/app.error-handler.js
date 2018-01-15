"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var __param = (this && this.__param) || function (paramIndex, decorator) {
    return function (target, key) { decorator(target, key, paramIndex); }
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var ngx_toastr_1 = require("ngx-toastr");
var error_log_service_1 = require("../services/event/error.log.service");
// import * as Raven from 'raven-js'
var AppErrorHandler = /** @class */ (function () {
    function AppErrorHandler(ngZone, injector, errorLogService) {
        this.ngZone = ngZone;
        this.injector = injector;
        this.errorLogService = errorLogService;
    }
    Object.defineProperty(AppErrorHandler.prototype, "toastr", {
        get: function () {
            return this.injector.get(ngx_toastr_1.ToastrService);
        },
        enumerable: true,
        configurable: true
    });
    AppErrorHandler.prototype.handleError = function (error) {
        var _this = this;
        this.ngZone.run(function () {
            _this.errorLogService.logError(error);
            _this.toastr.error(error.message, 'Error');
        });
        //throw error;
    };
    AppErrorHandler = __decorate([
        __param(0, core_1.Inject(core_1.NgZone)),
        __param(1, core_1.Inject(core_1.Injector)),
        __param(2, core_1.Inject(error_log_service_1.ErrorLogService)),
        __metadata("design:paramtypes", [core_1.NgZone,
            core_1.Injector,
            error_log_service_1.ErrorLogService])
    ], AppErrorHandler);
    return AppErrorHandler;
}());
exports.AppErrorHandler = AppErrorHandler;
//# sourceMappingURL=app.error-handler.js.map