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
var shared_service_helper_1 = require("./../event/shared.service.helper");
var core_1 = require("@angular/core");
var http_1 = require("@angular/http");
require("rxjs/add/operator/map");
var VegetableService = /** @class */ (function () {
    function VegetableService(_http) {
        this._http = _http;
        this.serviceApiEndPoint = 'http://localhost:62657/api/vegetable';
        this.debugApiEndPoint = 'http://localhost:5000/api/vegetable';
        this.isDebug = false;
        this.apiEndPoint = this.isDebug ? this.debugApiEndPoint : this.serviceApiEndPoint;
    }
    VegetableService.prototype.getVegetable = function (id) {
        return this._http.get(this.apiEndPoint + '/' + id)
            .map(function (res) { return res.json(); });
    };
    VegetableService.prototype.create = function (vegetable) {
        console.log('In Create');
        console.log(vegetable);
        return this._http.post(this.apiEndPoint, vegetable)
            .map(function (res) { return res.json(); });
    };
    VegetableService.prototype.update = function (vegetable) {
        return this._http.put(this.apiEndPoint + '/' + vegetable.keyValuePairInfo.id, vegetable)
            .map(function (res) { return res.json(); });
    };
    VegetableService.prototype.delete = function (id) {
        return this._http.delete(this.apiEndPoint + '/' + id)
            .map(function (res) { return res.json(); });
    };
    VegetableService.prototype.getVegetables = function (filter) {
        return this._http.get(this.apiEndPoint + '?' + shared_service_helper_1.SharedServiceHelper.toQueryString(filter))
            .map(function (res) { return res.json(); });
    };
    VegetableService = __decorate([
        core_1.Injectable(),
        __metadata("design:paramtypes", [http_1.Http])
    ], VegetableService);
    return VegetableService;
}());
exports.VegetableService = VegetableService;
//# sourceMappingURL=vegetable.service.js.map