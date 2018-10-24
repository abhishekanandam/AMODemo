var mainApp = angular.module("mainApp", [ "ngTable", "ui.grid", "ngMessages", "ngRoute"]).
    constant("baseUrl", "http://localhost:49572/Index.html").
    config(function ($routeProvider, $locationProvider, configServiceProvider) {

        //console.log(configServiceProvider);

        configServiceProvider.setName("Demo Service Provider");

        $routeProvider.
            when('/home', {
                myText: 'my text',
                templateUrl: 'angularscripts/template/home.html',
                controller: 'homeController'
            }).
        when('/home/:param', {
            templateUrl: 'angularscripts/template/home.html',
            controller: 'homeController'
        }).
            when('/about', {
                templateUrl: 'angularscripts/template/about.html',
                controller: 'aboutController'
            }).
            when('/contact', {
                templateUrl: 'angularscripts/template/contact.html',
                controller: 'contactController'
            }).
             when('/form', {
                 templateUrl: 'angularscripts/template/formdemo.html',
                 controller: 'formDemoController',
                 controllerAs: 'formCtrl'
             }).
            when('/other', {
                templateUrl: 'angularscripts/template/otherdemo.html',
                controller: 'otherDemoController',
            }).
            when('/test1', {
                templateUrl: 'test1.html',
                controller: 'otherDemoController'
            }).
            when('/test2', {
                templateUrl: 'test2.html',
                controller: 'otherDemoController'
            }).
            when('/test3', {
                templateUrl: 'test3.html',
                controller: 'otherDemoController'
            }).
            when('/test4', {
                templateUrl: 'test4.html',
                //controller: 'otherDemoController'
            }).
            when('/test5', {
                templateUrl: 'test5.html',
                controller: 'otherDemoController'
            }).
             when('/login', {
                 templateUrl: '/login.html',
                 //controller: 'otherDemoController'
             }).
             when('/subunsub', {
                 templateUrl: '/subunsub.html',
                 controller: 'otherDemoController'
             }).
        otherwise({
            redirectTo: '/Index.html'
        })

        $locationProvider.html5Mode(true);
    })