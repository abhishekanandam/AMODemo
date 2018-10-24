mainApp.directive("exists", function ($q, $timeout) {

    return {
        require: 'ngModel',
        link: function (scope, element, attributes, control) {
            // temporary data from local variable
            var userNames = ['Abhishek', 'Anandam'];

            console.log(control);

            control.$asyncValidators.exists = function (modelValue, viewValue) {
                if (control.$isEmpty(modelValue)) {
                    return $q.when();
                }

                var defer = $q.defer();

                // to imitate the behavior of service access
                // In real time, fire $http and get value then validate
                $timeout(function () {
                    if (userNames.toLocaleString().toLowerCase().indexOf(modelValue.toLowerCase()) === -1) // not found
                    {
                        defer.resolve(); // wow, this country available
                    }
                    else {
                        defer.reject();
                    }
                }, 1000);

                return defer.promise;
            };
        }
    };
});