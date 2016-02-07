/// <reference path="angular.js" />
/// <reference path="common.js" />
myApp.controller("customfilterController", function ($scope) {

    var employees = [
    { firstName: 'Junaid', lastName: 'Ameen', gender: 1, salary: '10000', joindate: new Date("November 23, 2010") },
    { firstName: 'Nuha', lastName: 'kareem', gender: 2, salary: '20000', joindate: new Date("March 1, 2009") },
    { firstName: 'Jibran', lastName: 'Ahmed', gender: 3, salary: '30000', joindate: new Date("January 2, 2016") },
    { firstName: 'Talha', lastName: '', gender: 1, salary: '40000', joindate: new Date("April 3, 2013") },
    { firstName: 'Manha', lastName: 'Fathima', gender: 2, salary: '50000', joindate: new Date("May 6, 2015") }
    ];

    $scope.employees = employees;

});

myApp.filter("gender", function () {
    return function (gender) {
        switch (gender) {
            case 1: return "Male";
            case 2: return "Female";
            case 3: return "Not disclosed";
        }
    }
});



