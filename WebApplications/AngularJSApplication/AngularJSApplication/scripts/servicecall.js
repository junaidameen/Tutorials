/// <reference path="angular.js" />
/// <reference path="common.js" />

myApp.controller("serviceCallController", function ($scope,$http,$log) {
    //$http.get('EmployeeService/EmployeeService.svc/GetEmployees')
    //.then(function (response) {
    //    $scope.employees = response.data;
    //});

    var successCallBack = function (response) {
        $scope.employees = response.data;
        $log.info(response);
    };

    var errorCallBack = function (reason) {
        $log.info(reason);
    };

    $http({
        method: 'GET',
        url: 'EmployeeService/EmployeeService.svc/GetEmployees'
    }).then(successCallBack, errorCallBack);
});








