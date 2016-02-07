/// <reference path="angular.js" />

var examples = [
    { filename: "BindingExpression.html", topic: "BindingExpression" },
    { filename: "HandleEvents.html", topic: "Handling Events" },
    { filename: "Directive.html", topic: "Directives" },
    { filename: "Filters.html", topic: "Filters" },
    { filename: "CustomFilter.html", topic: "Custom Filters" },
    { filename: "ServiceCall.html", topic: "Service Call Example" },
    { filename: "CustomService.html", topic: "Custom Service Example" },
    { filename: "ScrolltoContent.html", topic: "Scroll Example" }
];

var myApp = angular.module("myModule", []);

myApp.controller("commonController", function ($scope) {

    $scope.examples = examples;
    $scope.indextitle = "Angular JS Examples"
    $scope.bexptitle = "Binding Expression Example";

    var employee = {
        firstname: 'Junaid',
        lastname: 'Ameen',
        gender: 'Male'
    };

    $scope.employee = employee;
   

});

myApp.directive("backtolist", function () {
    return {
        template: "<br/><a ng-href='Index.html'>Back to Index</a>"
    };
});




