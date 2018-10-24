mvcApp.component("accordionPanel", {

    transclude: true,
    require: {
        'parent': '^accordion'
    },
    bindings: {
        heading: '@',
    },
    templateUrl: 'angularscripts/template/accordionpanel.html',
    controller: function ($element) {
        var self = this;
        // register the panel in init
        self.$onInit = function () {
            console.log("element:" + $element)
            self.parent.addPanel(self);
        };
        self.$onChanges = function (changesObj) {

            console.log(changesObj);
        }
        // Turns on the panel by changing selected to true
        self.turnOn = function () {
            self.selected = true;
        };
        // Turns off the panel by changing selected to false
        self.turnOff = function () {
            self.selected = false;
        };
        // Selects a the current selected panel
        self.select = function () {
            self.parent.selectPanel(self);
        };
    }

});