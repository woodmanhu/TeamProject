var demoApp = angular.module('demoApp', ['ngRoute']);
demoApp.config(function ($routeProvider) {
    $routeProvider
    .when('/',
    {
        templateUrl: 'ngtest1.html',
        controller: 'SimpleController',
        controllerAs:'ngtest1'
    })
    .when('/ngtest2',
    {
        templateUrl: 'ngtest2.html',
        controller: 'SimpleController',
        controllerAs:'ngtest2'
    })
    .otherwise({ redirectTo: '/' });
});
var controllers = {};
controllers.SimpleController = function ($scope) {
    $scope.customers = [
    { name: 'Kevin Hu', city: 'Burnsville' },
    { name: 'qiwen wang', city: 'Minnesota' },
      { name: 'yaqi wang', city: 'Tianjin' }
    ];
    $scope.addCustomer = function () {
        $scope.customers.push({
            name: $scope.newCustomer.name,
            city: $scope.newCustomer.city
        });
    };
}
demoApp.controller(controllers);

//opion1
//function SimpleController($scope) {
//    $scope.customers = [
//    { name: 'Kevin Hu', city: 'Burnsville' },
//    { name: 'qiwen wang', city: 'Minnesota' },
//      { name: 'yaqi wang', city: 'Tianjin' }
//    ];

//}

//option2
//demoApp.controller('SimpleController', function($scope) {
//    $scope.customers = [
//    { name: 'Kevin Hu', city: 'Burnsville' },
//    { name: 'qiwen wang', city: 'Minnesota' },
//      { name: 'yaqi wang', city: 'Tianjin' }
//    ];

//});



