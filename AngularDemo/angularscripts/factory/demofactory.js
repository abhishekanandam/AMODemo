mainApp.factory("demoFactory", function ($http, $q) {
    
    var factory = {};

    factory.factoryName = "Demo Factory";
    factory.artistDetails = function () {
        var deferred = $q.defer();

        $http({
            method: 'GET',
            url: 'Demo/Details',
        }).then(function (response) {
            deferred.resolve(response);
        }, function () {
            deferred.reject("Error while fetching the data");
        });

        return deferred.promise;
    };
    
    return factory;
});