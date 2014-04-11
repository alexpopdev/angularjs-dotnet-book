(function () {
    "use strict";

    var myAppModule = angular.module('myApp');

    myAppModule.controller('ExampleController', ['$scope', 'playerService',
            function ($scope, playerService) {
                $scope.players = [playerService.createPlayer(), playerService.createPlayer()];
            }
    ]);
})();