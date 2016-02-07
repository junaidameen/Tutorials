myApp.controller("directiveController", function ($scope) {

    var country = {
        name: 'India',
        capital: 'New Delhi',
        flag: './Images/ind-flag.png'
    };

    var employees = [
    { firstName: 'Junaid', lastName: 'Ameen', gender: 'Male', salary: '10000', joindate: new Date("November 23, 2010") },
    { firstName: 'Abdul', lastName: 'kareem', gender: 'Male', salary: '20000', joindate: new Date("March 1, 2009") },
    { firstName: 'Jibran', lastName: 'Ahmed', gender: 'Male', salary: '30000', joindate: new Date("January 2, 2016") },
    { firstName: 'Talha', lastName: '', gender: 'Male', salary: '40000', joindate: new Date("April 3, 2013") },
    { firstName: 'Manha', lastName: 'Fathima', gender: 'Male', salary: '50000', joindate: new Date("May 6, 2015") }
    ];


    $scope.country = country;
    $scope.employees = employees;

});


