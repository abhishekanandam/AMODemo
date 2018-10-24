mvcApp.controller("loginController", function ($scope, $location) {

    $scope.credentials = {
        username: '',
        password: ''
    };

    $scope.login = function (credentials) {

        console.log(credentials);
        $location.path("/home");
    };

});