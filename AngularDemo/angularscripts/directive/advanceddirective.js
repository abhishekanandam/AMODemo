mainApp.directive("directive1", function () {

	return {

		priority: 1,
		terminal: false,
		link: function () {
			console.log("Directive1");
		}
	}
});

mainApp.directive("directive2", function () {

	return {

		priority: 10,
		terminal: true,
		link: function () {
			console.log("Directive2");
		}
	}
});

mainApp.directive("directive3", function () {

	return {

		priority: 100,
		terminal: false,
		link: function () {
			console.log("Directive3");
		}
	}
});

mainApp.directive("directive4", function () {

	return {

		priority: 50,
		terminal: true,
		link: function () {
			console.log("Directive4");
		}
	}
});