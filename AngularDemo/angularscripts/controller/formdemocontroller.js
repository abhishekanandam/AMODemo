mainApp.controller("formDemoController", function ($scope) {

    var vm = this;

    this.title = "Form Demo";
    this.validationMsg = '';
    this.valid = false;
    this.formValidation = function () {
        this.valid = true;
        this.validationMsg = "Form Validation Success!";
    };

    this.educationDetails = [
        {
            name: "Post Graduation",
            Value: "PG"
        },
        {
            name: "Graduation",
            Value: "G"
        },
        {
            name: "Intermediate",
            Value: "I"
        },
        {
            name: "SSC",
            Value: "S"
        },
        {
            name: "Others",
            Value: "O"
        }
    ]

    this.source = [
        {
            name: "abc",
            Value: 1
        },
        {
            name: "xyz",
            Value: 2
        }
    ];

    this.gender = [
        {
            name: "Male",
            Value: 1
        },
        {
            name: "Female",
            Value: 2
        }
    ]

});