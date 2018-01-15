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
var core_1 = require("@angular/core");
var http_1 = require("@angular/http");
require("rxjs/add/operator/map");
var MeatService = /** @class */ (function () {
    function MeatService(_http) {
        this._http = _http;
        this.serviceApiEndPoint = 'http://localhost:62657/api/meat';
        this.debugApiEndPoint = 'http://localhost:5000/api/meat';
        this.isDebug = false;
        this.apiEndPoint = this.isDebug ? this.debugApiEndPoint : this.serviceApiEndPoint;
    }
    MeatService.prototype.getMeat = function (id) {
        return this._http.get(this.apiEndPoint + '/' + id)
            .map(function (res) { return res.json(); });
    };
    MeatService.prototype.create = function (meat) {
        console.log('In Create');
        console.log(meat);
        return this._http.post(this.apiEndPoint, meat)
            .map(function (res) { return res.json(); });
    };
    MeatService.prototype.update = function (meat) {
        return this._http.put(this.apiEndPoint + '/' + meat.keyValuePairInfo.id, meat)
            .map(function (res) { return res.json(); });
    };
    MeatService.prototype.delete = function (id) {
        return this._http.delete(this.apiEndPoint + '/' + id)
            .map(function (res) { return res.json(); });
    };
    MeatService.prototype.getMeats = function () {
        return this._http.get(this.apiEndPoint)
            .map(function (res) { return res.json(); });
    };
    MeatService = __decorate([
        core_1.Injectable(),
        __metadata("design:paramtypes", [http_1.Http])
    ], MeatService);
    return MeatService;
}());
exports.MeatService = MeatService;
//# sourceMappingURL=meat.service.js.map