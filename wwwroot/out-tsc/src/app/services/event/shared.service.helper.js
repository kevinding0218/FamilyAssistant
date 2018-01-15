"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var SharedServiceHelper = /** @class */ (function () {
    function SharedServiceHelper() {
    }
    SharedServiceHelper.toQueryString = function (obj) {
        // prop = value&
        var parts = [];
        for (var property in obj) {
            var value = obj[property];
            if (value != null && value != undefined)
                parts.push(encodeURIComponent(property) + '=' + encodeURIComponent(value));
        }
        return parts.join('&');
    };
    return SharedServiceHelper;
}());
exports.SharedServiceHelper = SharedServiceHelper;
//# sourceMappingURL=shared.service.helper.js.map