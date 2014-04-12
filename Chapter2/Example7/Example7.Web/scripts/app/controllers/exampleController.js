(function () {
    "use strict";

    var myAppModule = angular.module('myApp');

    myAppModule.controller('ExampleController', ['$scope', '$location', 'playerService',
            function ($scope, $location, playerService) {
                $scope.players = [playerService.createPlayer(), playerService.createPlayer()];

                

                $scope.isMultiPlayerView = $location.path() == '/multiplayer';
            }
    ]);
})();