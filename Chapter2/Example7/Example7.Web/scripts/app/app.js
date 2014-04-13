(function () {
    "use strict";

    var myAppModule = angular.module('myApp', ['ngRoute']);

    myAppModule.config([
        '$routeProvider', function ($routeProvider) {
            $routeProvider.when('/singleplayer', { templateUrl: 'scripts/app/views/singlePlayer.html' });
            $routeProvider.when('/multiplayer', { templateUrl: 'scripts/app/views/multiPlayer.html' });
        }
    ]);

})();