mainApp.provider("configService", function () {
    
    var providerName = '';

    this.setName = function (name) {

        providerName = name;
    };

    this.$get = function () {

        return providerName;
    };

});