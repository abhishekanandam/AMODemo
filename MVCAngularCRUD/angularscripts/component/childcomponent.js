mvcApp.component("childComponent", {

    bindings: {
        name: '<',
        onUpdate: '&'
    },

    controller: function () {

        var self = this;

        self.$onChanges = function (changes) {
            self.name = angular.copy(changes.name.currentValue);
        };

        self.updateData = function () {
            self.onUpdate({
                $event: {
                    name: self.name
                }
            });
        };
    },
    templateUrl: 'angularscripts/template/childtemplate.html'
});