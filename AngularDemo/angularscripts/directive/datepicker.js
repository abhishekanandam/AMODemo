mainApp.directive("datePicker", function () {

    return {
        restrict: "EA",
        link: function (scope, el, attr) {
            el.datepicker({
                dateFormat: 'yy-mm-dd'
            });
        }
    };
});