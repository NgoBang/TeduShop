(function (app) {
    'use strict';
    app.factory('authData', [
        function () {
            var authDataFactory = {};
            var authentication = {
                IsAuthenticated: false,
                username: ""
            };
            authDataFactory.authenticationData = authentication;

            return authDataFactory;
        }
    ]);
})(angular.module('tedushop.common'));