var eventApp = angular.module('eventApp', []);
var baseUrl = '../api/Events/';
var url = "";
eventApp.factory('eventFactory', function ($http) {
    return {
        getEventslist: function () {
            url = baseUrl + "GetEvents";
            return $http.get(url);
        },
        getEvent: function (event) {
            url = baseUrl + "GetEvent/" + event.Id;
            return $http.get(url);
        },
        //getEventUrl: function (eventurl) {
        //    url = baseUrl + "GetEventUrl/" + event.Url;
        //    return $http.get(url);
        //},
    }
});
eventApp.controller('eventAppController', function PostController($scope, eventFactory) {
    $scope.events = [];
    $scope.event = null;

    $scope.get = function () {
        $scope.event = this.event;
        $('#viewModal').modal('show');
    };
    $scope.getAll = function () {
        eventFactory.getEventslist().success(function (Data) {
            $scope.events = Data;
        }).error(function (data) {
            $scope.error = "An Error has occured while Loading events! " + data.ExceptionMessage;
        });

    };

    
    $scope.getAll();
  
});
            
//eventApp.controller('eventController', function ($scope, $http) {
//    $http.get(baseUrl).success(function (results) {
//        $scope.eventData = results;
//    })

//})
//eventApp.controller('eventController', function ($scope, eventService) {
//    getEvents();
//    function getEvents() {
//        eventService.getEvents(function (results) {
//            $scope.eventData = results;
//        })
//    }
//});
        
