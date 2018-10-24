var mvcApp = angular.module("mvcApp", ['ngRoute'])
    .config(function ($routeProvider, $locationProvider) {

        $routeProvider.
             when('/brand', {
                 templateUrl: 'angularscripts/template/brand.html',
                 //controller: 'indexController'
             }).
            when('/home', {
                templateUrl: 'angularscripts/template/Index.html',
                controller: 'indexController'
            }).
            when('/about', {
                templateUrl: 'angularscripts/template/about.html',
                controller: 'indexController'
            }).
            when('/contact', {
                templateUrl: 'angularscripts/template/contact.html',
            }).
            when('/register', {
                templateUrl: 'angularscripts/template/register.html',
            }).
            when('/login', {
                templateUrl: 'angularscripts/template/login.html',
                conrtroller: "loginController"
            }).
        otherwise({
            redirectTo: '/brand'
        })

        $locationProvider.html5Mode(true);
    }).
controller("rootController", function () {

    
});