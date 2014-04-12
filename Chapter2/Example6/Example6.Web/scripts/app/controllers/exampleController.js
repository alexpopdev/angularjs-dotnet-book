(function () {
    "use strict";

    var myAppModule = angular.module('myApp');

    myAppModule.controller('ExampleController', ['$scope', '$timeout', 'playerService',
            function ($scope, $timeout, playerService) {
                $scope.reset = function () {
                    $scope.players = null;
                    playerService.resetPlayerCount();
                }

                $scope.callwindowsetTimeout = function () {
                    $scope.players = [];
                    window.setTimeout(function () {
                        $scope.players = [playerService.createPlayer(), playerService.createPlayer()];
                        playerService.resetPlayerCount();
                        console.log($scope.players.length.toString() + " players were created.");
                    }, 2000);
                };

                $scope.call$timeout = function () {
                    $scope.players = [];
                    $timeout(function () {
                        $scope.players = [playerService.createPlayer(), playerService.createPlayer()];
                        playerService.resetPlayerCount();
                    }, 2000);
                };

                $scope.callwindowsetTimeoutWithin$scope$apply = function () {
                    $scope.players = [];
                    window.setTimeout(function () {
                        $scope.$apply(function () {
                            $scope.players = [playerService.createPlayer(), playerService.createPlayer()];
                            playerService.resetPlayerCount();
                        });
                    }, 2000);
                };
            }
    ]);
})();