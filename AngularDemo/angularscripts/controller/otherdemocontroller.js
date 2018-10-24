mainApp.controller("otherDemoController", function ($scope) {

    $scope.mainTitle = "In-built directive's demo";
    $scope.ngTemplate = "ng-template demo";

    $scope.ngMouseDown = "ng-mousedown demo";
    $scope.angularTable = "Angular JS Tables Demo";
    $scope.uiGridDemo = "UI Grid Demo";

    $scope.ngModelOptionsUpdateOn = "ng model options update on";
    $scope.ngModelOptionsDebounce = "ng model options debounce";
    $scope.ngModelOptionsGetterSetter = "ng model options getter setter";
    $scope.ngModelOptionsRollback = "ng model options rollback";

    $scope.count = 0;
    $scope.getdetails = function () {

        $scope.count = $scope.count + 1;
    }

    $scope.gridOptions = {
        
        enableFiltering: true,
        columnDefs: [
        { field: 'name' },
        { field: 'age' },
        { field: 'location' }
        ],
        onRegisterApi: function (gridApi) {

            $scope.grid1Api = gridApi;
        }

    };

    $scope.gridOptions.data = $scope.empData;

    $scope.empData = [
        {
            name: "kjsfklsjd",
            age: 25,
            location: "Bangalore"
        },
        {
            name: "hsdfjas",
            age: 26,
            location: "Hyderbad"
        },
        {
            name: "kfssjflsjd",
            age: 27,
            location: "Pune"
        },
        {
            name: "iosjdfjsd",
            age: 28,
            location: "Chennai"
        }
    ];

});