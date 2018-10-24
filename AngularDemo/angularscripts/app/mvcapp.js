var mvcApp = angular.module("mvcApp", ['ngRoute']).
    config(function ($routeProvider, $locationProvider) {

        $routeProvider.
            when('/start', {
                templateUrl: './home/mainaction',
                controller: 'mainController'
            }).
        otherwise({
            redirectTo: '/start'
        });

        $locationProvider.html5Mode(true);
    });