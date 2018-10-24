mainApp.controller("homeController", function ($scope, $routeParams, $route, demoFactory, demoService) {

    $scope.factoryData = {};
    $scope.serviceData = {};
    $scope.homePage = "This is your home page."

    $scope.routeParam = $routeParams.param

    $scope.getArtistDetails = function () {
        demoFactory.artistDetails().then(
            function (response) {

                //console.log(response.data);
                $scope.factoryData.artistData = response.data;
            },
            function () {
                console.log("factory error");
            }
            )
    };

    $scope.getArtistDetailsById = function (artistId) {
        demoService.artistDetailsById(artistId).then(
            function (response) {

                //console.log(response.data);
                $scope.serviceData.artistData = response.data[0];
            },
            function () {
                console.log("service error");
            }
            )
    }

    $scope.getArtistDetails();
    $scope.getArtistDetailsById(1);
    console.log("route: " + $route.current.myText);

    //console.log($routeParams);
});