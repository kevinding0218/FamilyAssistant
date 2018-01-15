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
var ngx_toastr_1 = require("ngx-toastr");
var meat_service_1 = require("./../../../../services/meal/meat.service");
var router_1 = require("@angular/router");
var core_1 = require("@angular/core");
var MeatFormComponent = /** @class */ (function () {
    function MeatFormComponent(_route, _router, _meatService, toastr) {
        var _this = this;
        this._route = _route;
        this._router = _router;
        this._meatService = _meatService;
        this.toastr = toastr;
        this.FormHeader = 'Update Meat Item';
        this.isDevelopment = (JSON.parse(localStorage.getItem('currentUser')) == 'true' ? true : false);
        this.successfulSave = false;
        this.meat = {
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
            _this.meat.keyValuePairInfo.id = (typeof p['id'] == 'undefined') ? 0 : +p['id'];
        });
    }
    MeatFormComponent.prototype.ngOnInit = function () {
        var _this = this;
        var sources = [];
        if (this.meat.keyValuePairInfo.id) {
            sources.push(this._meatService.getMeat(this.meat.keyValuePairInfo.id));
            Rx_1.Observable.forkJoin(sources).subscribe(function (data) {
                if (_this.meat.keyValuePairInfo.id) {
                    _this.FormHeader = 'Update Meat Item';
                    _this.setmeat(data[0]);
                }
            }, function (err) {
                if (err.status == 404)
                    _this._router.navigate(['/pages/404']);
            });
        }
        else {
            this.FormHeader = 'Create New Meat';
        }
    };
    MeatFormComponent.prototype.setmeat = function (vege) {
        this.meat.keyValuePairInfo.name = vege.keyValuePairInfo.name;
        this.meat.addedOn = vege.addedOn;
        this.meat.addedByUserId = vege.addedByUserId;
        this.meat.updatedOn = vege.updatedOn;
        this.meat.lastUpdatedByUserId = vege.lastUpdatedByUserId;
        this.meat.note = vege.note;
    };
    MeatFormComponent.prototype.submit = function () {
        var _this = this;
        if (this.meat.keyValuePairInfo.id) {
            this.meat.lastUpdatedByUserId = 2;
            this._meatService.update(this.meat)
                .subscribe(function (data) {
                _this.successfulSave = true;
                _this._router.navigate(['/meal/meatList']);
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
            this.meat.addedByUserId = 2;
            this.meat.addedOn = new Date();
            this._meatService.create(this.meat)
                .subscribe(function (x) {
                _this.toastr.success('This meat has been successfully inserted!', 'INSERT SUCCESS');
                _this._router.navigate(['/meal/meatList']);
            });
        }
    };
    MeatFormComponent.prototype.resetFormValue = function () {
        this.meat.keyValuePairInfo.name = this.oldName;
        this.meat.note = this.oldNote;
    };
    MeatFormComponent.prototype.deleteMeat = function () {
        if (confirm("Are you sure?")) {
            // this._meatService.delete(this.meat.keyValuePairInfo.id)
            //     .subscribe(x => {
            //         this._router.navigate(['/meal/meatForm/new']);
            //     });
        }
    };
    MeatFormComponent = __decorate([
        core_1.Component({
            selector: 'app-meat-form',
            templateUrl: './meat-form.component.html'
        }),
        __metadata("design:paramtypes", [router_1.ActivatedRoute,
            router_1.Router,
            meat_service_1.MeatService,
            ngx_toastr_1.ToastrService])
    ], MeatFormComponent);
    return MeatFormComponent;
}());
exports.MeatFormComponent = MeatFormComponent;
//# sourceMappingURL=meat-form.component.js.map