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
var Rx_1 = require("rxjs/Rx");
var router_1 = require("@angular/router");
var vegetable_service_1 = require("./../../../../services/meal/vegetable.service");
var core_1 = require("@angular/core");
var ngx_toastr_1 = require("ngx-toastr");
var VegetableFormComponent = /** @class */ (function () {
    function VegetableFormComponent(_route, _router, _vegetableService, toastr) {
        var _this = this;
        this._route = _route;
        this._router = _router;
        this._vegetableService = _vegetableService;
        this.toastr = toastr;
        this.FormHeader = 'Update Vegetable Item';
        this.isDevelopment = (JSON.parse(localStorage.getItem('currentUser')) == 'true' ? true : false);
        this.successfulSave = false;
        this.vegetable = {
            keyValuePairInfo: {
                id: null,
                name: ''
            },
            addedOn: null,
            addedByUserId: null,
            updatedOn: null,
            lastUpdatedByUserId: null,
            note: ''
        };
        _route.params.subscribe(function (p) {
            _this.vegetable.keyValuePairInfo.id = (typeof p['id'] == 'undefined') ? 0 : +p['id'];
        });
    }
    VegetableFormComponent.prototype.ngOnInit = function () {
        var _this = this;
        var sources = [];
        if (this.vegetable.keyValuePairInfo.id) {
            sources.push(this._vegetableService.getVegetable(this.vegetable.keyValuePairInfo.id));
            Rx_1.Observable.forkJoin(sources).subscribe(function (data) {
                if (_this.vegetable.keyValuePairInfo.id) {
                    _this.setVegetable(data[0]);
                }
            }, function (err) {
                if (err.status == 404)
                    _this._router.navigate(['/pages/404']);
            });
        }
        else {
            this.FormHeader = 'Create New Vegetable';
        }
    };
    VegetableFormComponent.prototype.setVegetable = function (vege) {
        this.oldName = this.vegetable.keyValuePairInfo.name = vege.keyValuePairInfo.name;
        this.vegetable.addedOn = vege.addedOn;
        this.vegetable.addedByUserId = vege.addedByUserId;
        this.vegetable.updatedOn = vege.updatedOn;
        this.vegetable.lastUpdatedByUserId = vege.lastUpdatedByUserId;
        this.oldNote = this.vegetable.note = vege.note;
    };
    VegetableFormComponent.prototype.submit = function () {
        var _this = this;
        if (this.vegetable.keyValuePairInfo.id) {
            this.vegetable.lastUpdatedByUserId = 2;
            this._vegetableService.update(this.vegetable)
                .subscribe(function (data) {
                _this.successfulSave = true;
                _this._router.navigate(['/meal/vegetableList']);
            }, function (err) {
                _this.successfulSave = false;
                if (err.status === 400) {
                    // handle validation error
                    var validationErrorDictionary = JSON.parse(err.text());
                    for (var fieldName in validationErrorDictionary) {
                        if (validationErrorDictionary.hasOwnProperty(fieldName)) {
                            _this.toastr.warning('Invalid Update', validationErrorDictionary[fieldName]);
                        }
                    }
                }
            });
        }
        else {
            this.vegetable.addedByUserId = 2;
            this.vegetable.addedOn = new Date();
            this._vegetableService.create(this.vegetable)
                .subscribe(function (x) {
                _this.toastr.success('This vegetable has been successfully inserted!', 'INSERT SUCCESS');
                _this._router.navigate(['/meal/vegetableList']);
            });
        }
    };
    VegetableFormComponent.prototype.resetFormValue = function () {
        this.vegetable.keyValuePairInfo.name = this.oldName;
        this.vegetable.note = this.oldNote;
    };
    VegetableFormComponent.prototype.deleteVegetable = function () {
        if (confirm("Are you sure?")) {
            // this._vegetableService.delete(this.vegetable.keyValuePairInfo.id)
            //     .subscribe(x => {
            //         this._router.navigate(['/meal/vegetableForm/new']);
            //     });
        }
    };
    VegetableFormComponent = __decorate([
        core_1.Component({
            selector: 'app-vegetable-form',
            templateUrl: './vegetable-form.component.html'
        }),
        __metadata("design:paramtypes", [router_1.ActivatedRoute,
            router_1.Router,
            vegetable_service_1.VegetableService,
            ngx_toastr_1.ToastrService])
    ], VegetableFormComponent);
    return VegetableFormComponent;
}());
exports.VegetableFormComponent = VegetableFormComponent;
//# sourceMappingURL=vegetable-form.component.js.map