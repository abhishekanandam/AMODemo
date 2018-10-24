var spaApp = angular.module("spaApp", ['ngRoute']).
config(function ($routeProvider) {

    $routeProvider
    when('/home', {
        templateUrl: '/template/home.html',
        controller: 'homeController'
    }).
    when('/authenticated', {
        templateUrl: '/template/authenticated.html',
        controller: 'authenticateController'
    }).
    when('/authorized', {
        templateUrl: '/template/authorize.html',
        controller: 'authorizeController'
    }).
    when('/login', {
        templateUrl: '/template/login.html',
        controller: 'loginController'
    }).
     when('/unauthorized', {
         templateUrl: '/template/unauthorize.html',
         controller: 'unauthorizeController'
     }).
    when('/',
    {
        redirectTo: '/home'
    })
}).
constant('serviceBasePath', 'http://localhost:64404').
controller('homeController', function ($scope, dataService) {

    $scope.data = "";
    dataService.GetAnanymousData().then(function (data) {

        $scope.data = data;
    })

}).
controller('authenticateController', function ($scope, dataService) {

    $scope.data = "";
    dataService.GetAuthenticatedData().then(function (data) {

        $scope.data = data;
    })

}).
controller('authorizeController', function ($scope, dataService) {

    $scope.data = "";
    dataService.GetAuthorizedData().then(function (data) {

        $scope.data = data;
    })
}).
controller('loginController', function ($scope, accountService, $location) {

    $scope.account = {

        username: '',
        password: ''
    }

    $scope.message = "";
    $scope.login = function () {

        accountService.login($scope.account).then(function (data) {

            $location.path('/home');
        }, function (error) {
            $scope.message = error.error_description;
        })
    }

}).
controller('unauthorizeController', function ($scope) {

    $scope.data = 'Sorry! You are not authorized to use this resource.';
}).
factory('dataService', function ($http, serviceBasePath) {

    var fac = {};

    fac.GetAnanymousData = function () {

        return $http.get(serviceBasePath + '/api/data/forall')
                .then(function (response) {
                    return response.data;
                })
    };


    fac.GetAuthenticatedData = function () {

        return $http.get(serviceBasePath + '/api/data/autheticate')
                .then(function (response) {
                    return response.data;
                })
    };

    fac.GetAuthorizedData = function () {

        return $http.get(serviceBasePath + '/api/data/authorized')
                .then(function (response) {
                    return response.data;
                })
    }
}).
factory('userService', function () {

    var fac = {};

    fac.currentUser = null;
    fac.SetCurrentUser = function (user) {

        fac.currentUser = user;
        sessionStorage.user = angular.toJson(user);
    }

    fac.GetCurrentUser = function () {

        fac.currentUser = angular.fromJson(sessionStorage.user);
        return fac.currentUser;
    }

    return fac;
}).
factory('accountService', function ($http, $q, serviceBasePath, userService) {

    var fac = {};

    fac.login = function (user) {

        var obj = { 'username': user.username, 'password': user.password, 'grant_type': 'password' };
        Object.toparams = function ObjectsToParams(obj) {

            var p = [];
            for(var key in obj)
            {
                p.push(key + '' + encodeURIComponent(obj[key]));
            }
            return p.join('&');
        }

        var defer = $q.defer();

        $http({

            method: 'post',
            url: serviceBasePath,
            data: Object.toparams(obj),
            headers: {
                'Content-Type': 'application/x-www-form-urlencoded'
            }
        }).then(
        function (response) {
            userService.SetCurrentUser(response.data);
            defer.resolve(response.data);
        },
        function (error) {
            defer.reject(error.data);
        }
        )

        return defer.promise;
    }

    fac.logout = function () {

        userService.currentUser = null;
        userService.SetCurrentUser(userService.currentUser);

    }

    return fac;

}).
config(function ($httpProvider) {

    var interceptor = function (userService, $q, $location) {

        return {
            request: function (config) {
                var currentUser = userService.GetCurrentUser();
                if(currentUser != null)
                {
                    config.headers['Authorization'] = "Bearer" + currentUser.access_token;
                }
                return config;
            },
            responseError: function (rejectionError) {
                if (rejection.status === 401) {

                    $location.path('/login');
                    return $q.reject(rejection);
                }
                if (rejection.status === 403) {
                    $location.path('/unauthorized');
                    return $q.reject(rejection);
                }
                return $q.reject(rejection);
            }
        }
    }

    var params = ['userService', '$q', '$location'];
    interceptor.$inject = params;

    $httpProvider.interceptor.push(interceptor);
})














