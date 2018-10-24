mvcApp.component("menuBar", {

    templateUrl: 'angularscripts/template/navbarmenu.html',
    controller: function () {

        this.brand = {
            name: "Angular Demo",
            href: "Index"
        }

        this.menuItems = [
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
        ]

    }

});