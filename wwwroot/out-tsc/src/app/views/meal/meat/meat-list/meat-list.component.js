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
var router_1 = require("@angular/router");
var core_1 = require("@angular/core");
var meat_service_1 = require("../../../../services/meal/meat.service");
var MeatListComponent = /** @class */ (function () {
    function MeatListComponent(_meatService, router) {
        this._meatService = _meatService;
        this.router = router;
        this.isDevelopment = (JSON.parse(localStorage.getItem('currentUser')) == 'true' ? true : false);
        this.ngx_rows = [];
        this.ngx_loadingIndicator = true;
        this.ngx_reorderable = true;
        this.temp = [];
        this.ngx_columns = [
            { prop: 'keyValuePairInfo.id', name: 'Id' },
            { prop: 'keyValuePairInfo.name', name: 'Name' },
            { prop: 'addedOn', name: 'Added On' },
            { prop: 'addedByUserName', name: 'Added By' },
            { prop: 'numberOfEntreeIncluded', name: 'Entrees Included' },
            { prop: 'lastUpdatedByOn', name: 'Updated On' },
            { prop: 'stapleFood', name: 'Staple Food' },
            { prop: 'note', name: 'Note' }
        ];
    }
    MeatListComponent.prototype.ngOnInit = function () {
        this.populateDataTable();
    };
    MeatListComponent.prototype.populateDataTable = function () {
        var _this = this;
        this._meatService.getMeats()
            .subscribe(function (result) {
            _this.ngx_rows = _this.temp = result;
            setTimeout(function () { _this.ngx_loadingIndicator = false; }, 1500);
        });
    };
    MeatListComponent.prototype.editMainTableItem = function (value) {
        console.log('editMainTableItem value: ' + value);
        this.router.navigate(['/meal/meatForm/' + value]);
    };
    MeatListComponent.prototype.updateFilter = function (event) {
        var val = event.target.value.toLowerCase();
        // filter our data
        var temp = this.temp.filter(function (d) {
            return d.keyValuePairInfo.name.toLowerCase().indexOf(val) !== -1 || !val;
        });
        // update the rows
        this.ngx_rows = temp;
        // Whenever the filter changes, always go back to the first page
        this.mainTable.offset = 0;
    };
    MeatListComponent.prototype.onPageMainTable = function (event) {
        clearTimeout(this.ngx_timeout);
        this.ngx_timeout = setTimeout(function () {
            console.log('onPageMainTable!', event);
        }, 100);
    };
    MeatListComponent.prototype.onPageDetailTable = function (event) {
        clearTimeout(this.ngx_timeout);
        this.ngx_timeout = setTimeout(function () {
            console.log('onPageDetailTable!', event);
        }, 100);
    };
    MeatListComponent.prototype.toggleExpandRow = function (row, expanded) {
        console.log('toggleExpandRow Row: ', row);
        console.log('toggleExpandRow expanded: ', expanded);
        var vegeId = row.keyValuePairInfo.Id;
        this.mainTable.rowDetail.toggleExpandRow(row);
    };
    MeatListComponent.prototype.onDetailToggle = function () {
        console.log('Detail Toggled', event);
    };
    __decorate([
        core_1.ViewChild('mainTable'),
        __metadata("design:type", Object)
    ], MeatListComponent.prototype, "mainTable", void 0);
    __decorate([
        core_1.ViewChild('levelOneDetailTable'),
        __metadata("design:type", Object)
    ], MeatListComponent.prototype, "detailtable", void 0);
    MeatListComponent = __decorate([
        core_1.Component({
            selector: 'app-meat-list',
            templateUrl: './meat-list.component.html'
        }),
        __metadata("design:paramtypes", [meat_service_1.MeatService, router_1.Router])
    ], MeatListComponent);
    return MeatListComponent;
}());
exports.MeatListComponent = MeatListComponent;
//# sourceMappingURL=meat-list.component.js.map