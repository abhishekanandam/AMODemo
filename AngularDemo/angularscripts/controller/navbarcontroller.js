mainApp.controller("navBarController", function ($scope, demoFactory, demoService, configService) {
    
    $scope.brandName = "Angular JS Demo";

    $scope.employees = [
    {
        department: 'Finance', employee: [
        { Name: 'Mark', Department: 'HR', Id: 1 },
        { Name: 'Tim', Department: 'Finance', Id: 2 },
        { Name: 'Frank', Department: 'Administration', Id: 3 }
        ]
    }
    ,
    {
        department: 'HR', employee: [
        { "Name": "John", "Id": 4 },
        { "Name": "Sam", "Id": 5 },
        { "Name": "Ravi", "Id": 6 }
        ]
    }
    ,
    {
        department: 'Administration', employee: [
        { "Name": "Ashish", "Id": 7 },
        { "Name": "Peter", "Id": 8 },
        { "Name": "Craig", "Id": 9 }
        ]
    }

    ]

    $scope.menuItems = [
        {
            name: "Home",
            href: "home"
        },
        {
            name: "About",
            href: "about"
        },
        {
            name: "Contact Us",
            href: "contact"
        },
        {
            name: "Form Demo",
            href: "form"
        },
        {
            name: "Other Demo",
            href: "other"
        },
        {
            name: "subscribe/unsubscribe demo",
            href: "subunsub"
        }
    ]

    $scope.directive = "Custom Dirctive Demo";

    $scope.footer = "@DateTime.Now.Year - Angular 1.X component Demo";

    $scope.id = "1";
    $scope.firstName = "Abhishek";
    $scope.lastName = "Anandam";
    $scope.fullName = function () {
        return $scope.firstName + "," + $scope.lastName;
    }

    console.log("service: " + demoService);
    console.log("factory: " + demoFactory);
    console.log("provider: " + configService);

    $scope.serviceName = demoService.serviceName;
    $scope.factoryName = demoFactory.factoryName;
    $scope.providerName = configService;

});