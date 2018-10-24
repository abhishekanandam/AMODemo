mainApp.component("componentDemo", {

    bindings: {
        footer: '@'
    },

    template: '<p>&copy; {{$ctrl.footer}}</p>'

});