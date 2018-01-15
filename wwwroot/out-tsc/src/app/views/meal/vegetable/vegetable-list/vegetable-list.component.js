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
var vegetable_service_1 = require("../../../../services/meal/vegetable.service");
var VegetableListComponent = /** @class */ (function () {
    function VegetableListComponent(_vegetableService, router) {
        this._vegetableService = _vegetableService;
        this.router = router;
        this.isDevelopment = (JSON.parse(localStorage.getItem('currentUser')) == 'true' ? true : false);
        this.PAGE_SIZE = 2;
        this.queryResult = {};
        this.query = {
            pageSize: this.PAGE_SIZE
        };
        this.columns = [
            { title: 'Id' },
            { title: 'Name', key: 'name', isSortable: true },
            { title: 'Added On', key: 'addedOn', isSortable: true },
            { title: 'Added By', key: 'addedBy', isSortable: true },
            { title: 'Entrees Included', key: 'entreesIncluded', isSortable: true },
            { title: 'Updated On', key: 'updatedOn', isSortable: true },
            { title: 'Staple Food', key: 'stapleFood', isSortable: true },
            { title: 'Note', key: 'note', isSortable: false },
            {}
        ];
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
    VegetableListComponent.prototype.ngOnInit = function () {
        this.populateDataTable();
    };
    VegetableListComponent.prototype.populateDataTable = function () {
        var _this = this;
        this._vegetableService.getVegetables(this.query)
            .subscribe(function (result) {
            _this.queryResult = result;
            _this.allVegetables = result.items;
            _this.ngx_rows = _this.temp = result.totalItemList;
            setTimeout(function () { _this.ngx_loadingIndicator = false; }, 1500);
        });
    };
    VegetableListComponent.prototype.onqueryChange = function () {
        // Client Side, for small dataset
        /* var queryResult = this.allVegetables;
    
        if (this.query.vegetableId)
          queryResult = queryResult.query(v => v.keyValuePairInfo.id == this.query.vegetableId);
    
        this.vegetables = queryResult; */
        this.query.page = 1;
        this.populateDataTable();
    };
    VegetableListComponent.prototype.resetquery = function () {
        this.query = {
            page: 1,
            pageSize: this.PAGE_SIZE
        };
        this.onqueryChange();
    };
    VegetableListComponent.prototype.sortBy = function (columnName) {
        if (this.query.sortBy == columnName) {
            this.query.isSortAscending = !this.query.isSortAscending;
        }
        else {
            this.query.sortBy = columnName;
            this.query.isSortAscending = true;
        }
        this.populateDataTable();
    };
    VegetableListComponent.prototype.onPageChange = function (_pageIndex) {
        this.query.page = _pageIndex;
        this.populateDataTable();
    };
    VegetableListComponent.prototype.editMainTableItem = function (value) {
        console.log('editMainTableItem value: ' + value);
        this.router.navigate(['/meal/vegetableForm/' + value]);
    };
    VegetableListComponent.prototype.updateFilter = function (event) {
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
    VegetableListComponent.prototype.onPageMainTable = function (event) {
        clearTimeout(this.ngx_timeout);
        this.ngx_timeout = setTimeout(function () {
            console.log('onPageMainTable!', event);
        }, 100);
    };
    VegetableListComponent.prototype.onPageDetailTable = function (event) {
        clearTimeout(this.ngx_timeout);
        this.ngx_timeout = setTimeout(function () {
            console.log('onPageDetailTable!', event);
        }, 100);
    };
    VegetableListComponent.prototype.onPageDetailDetailTable = function (event) {
        clearTimeout(this.ngx_timeout);
        this.ngx_timeout = setTimeout(function () {
            console.log('onPageDetailDetailTable!', event);
        }, 100);
    };
    VegetableListComponent.prototype.toggleExpandRow = function (row, expanded) {
        console.log('toggleExpandRow Row: ', row);
        console.log('toggleExpandRow expanded: ', expanded);
        var vegeId = row.keyValuePairInfo.Id;
        this.mainTable.rowDetail.toggleExpandRow(row);
    };
    VegetableListComponent.prototype.toggleExpandDetailRow = function (row, expanded) {
        console.log('toggleExpandDetailRow Row: ', row);
        console.log('toggleExpandDetailRow Row expanded: ', expanded);
        var entreeId = row.entreeId;
        this.detailtable.rowDetail.toggleExpandRow(row);
    };
    VegetableListComponent.prototype.onDetailToggle = function () {
        console.log('Detail Toggled', event);
    };
    VegetableListComponent.prototype.onDetailDetailToggle = function () {
        console.log('Detail Detail Toggled', event);
    };
    __decorate([
        core_1.ViewChild('mainTable'),
        __metadata("design:type", Object)
    ], VegetableListComponent.prototype, "mainTable", void 0);
    __decorate([
        core_1.ViewChild('levelOneDetailTable'),
        __metadata("design:type", Object)
    ], VegetableListComponent.prototype, "detailtable", void 0);
    __decorate([
        core_1.ViewChild('levelTwoDetailTable'),
        __metadata("design:type", Object)
    ], VegetableListComponent.prototype, "detaildetailtable", void 0);
    VegetableListComponent = __decorate([
        core_1.Component({
            selector: 'vegetable-list',
            templateUrl: './vegetable-list.component.html'
        }),
        __metadata("design:paramtypes", [vegetable_service_1.VegetableService, router_1.Router])
    ], VegetableListComponent);
    return VegetableListComponent;
}());
exports.VegetableListComponent = VegetableListComponent;
//# sourceMappingURL=vegetable-list.component.js.map