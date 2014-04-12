(function () {
    "use strict";

    var myAppModule = angular.module('myApp');

    myAppModule.directive('myPlayer', function () {
        return {
            restrict: 'E',
            templateUrl: 'scripts/app/views/player.html',
            scope: {
                player: "="
            }
        };
    });
})();