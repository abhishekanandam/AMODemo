mainApp.directive("preventMaxLength", function () {

    return {

        link: function (scope, element, attributes) {
            var oldVal = null;
            element.on("keyup keydown", function (e) {
                //console.log(element.val().length);

                if (Number(element.val().length) > Number(attributes.maxlength)) {

                    e.preventDefault();
                    element.val(oldVal);
                }
                else {
                    oldVal = Number(element.val());
                }

            });
        }
    };
});