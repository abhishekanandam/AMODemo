mainApp.service("demoService", function ($http, $q) {
    
    this.serviceName = "Demo Service";

    this.artistDetailsById = function (artistId) {
        var deferred = $q.defer();

        $http({
            method: 'GET',
            url: 'Demo/DetailsById',
            params: { id: artistId }
        }).then(function (response) {
            deferred.resolve(response);
        }, function () {
            deferred.reject("Error while fetching the data");
        });

        return deferred.promise;
    };
});