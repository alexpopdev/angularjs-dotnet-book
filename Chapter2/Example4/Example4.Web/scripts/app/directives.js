(function () {
    "use strict";

    var myAppModule = angular.module('myApp');

    myAppModule.directive('myPlayer', function () {
        return {
            restrict: 'E',
            templateUrl: 'player.html',
            scope: {
                player: "="
            }
        };
    });
})();