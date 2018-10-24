mvcApp.component("parentComponent", {

    controller: function () {
      
        this.name = 'Marcus Johns';

        this.updateName = function (event) {
            this.name = event.name;
        };
    },

    templateUrl: 'angularscripts/template/parenttemplate.html'
});
