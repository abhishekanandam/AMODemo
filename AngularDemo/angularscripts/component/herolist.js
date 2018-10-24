mainApp.component("heroList", {

    templateUrl: 'angularscripts/template/herolist.html',
    controller: function ($scope, $element, $attrs) {
        var ctrl = this;

        // This would be loaded by $http etc.
        ctrl.list = [
          {
              name: 'Superman',
              location: ''
          },
          {
              name: 'Batman',
              location: 'Wayne Manor'
          }
        ];

        ctrl.updateHero = function (hero, prop, value) {
            console.log("update hero: " + hero);
            console.log("update hero: " + prop);
            console.log("update hero: " + value);
            hero[prop] = value;
        };

        ctrl.deleteHero = function (hero) {
            console.log("delete hero: " + hero);
            var idx = ctrl.list.indexOf(hero);
            if (idx >= 0) {
                ctrl.list.splice(idx, 1);
            }
        };
    }
});