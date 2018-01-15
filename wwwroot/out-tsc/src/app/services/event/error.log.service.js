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
Object.defineProperty(exports, "__esModule", { value: true });
var http_1 = require("@angular/common/http");
var core_1 = require("@angular/core");
var ErrorLogService = /** @class */ (function () {
    function ErrorLogService() {
    }
    ErrorLogService.prototype.logError = function (error) {
        var date = new Date().toISOString();
        if (error instanceof http_1.HttpErrorResponse) {
            console.error(date, 'There was an HTTP error.', error.message, 'Status code:', error.status);
        }
        else if (error instanceof TypeError) {
            console.error(date, 'There was a Type error.', error.message);
        }
        else if (error instanceof Error) {
            console.error(date, 'There was a general error.', error.message);
        }
        else {
            if (error.status == 400) {
                var validationErrorDictionary = JSON.parse(error._body);
                for (var fieldName in validationErrorDictionary) {
                    if (validationErrorDictionary.hasOwnProperty(fieldName)) {
                        error.message = validationErrorDictionary[fieldName];
                    }
                }
            }
            console.error(date, 'Nobody threw an Error but something happened!', error.message);
        }
    };
    ErrorLogService = __decorate([
        core_1.Injectable(),
        __metadata("design:paramtypes", [])
    ], ErrorLogService);
    return ErrorLogService;
}());
exports.ErrorLogService = ErrorLogService;
//# sourceMappingURL=error.log.service.js.map