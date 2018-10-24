mainApp.directive("customDirective", function () {
    
    return {
        //Isolated scope
        scope: {
            id: '<', // one-way
            fName: '@', //string literal
            lName: '=', //two-way
            fullName: '&' // function 

        },
        transclude: true,
        restrict: 'EA',
        templateUrl: 'angularscripts/template/customdirectivetemplate.html',
        controller: function ($scope) {
            console.log("directive controller: " + $scope.fullName());
        },
        link: function($scope, element, attr){

            //console.log($scope);
            //console.log("element: " + element);
            //console.log("attribute: " + attr);

            element.bind("click", function () {

                $scope.directive = "new value";
                console.log($scope.directive);
            });
    }
        
    }
});