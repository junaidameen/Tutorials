myApp.controller("filterController", function ($scope) {

    var employees = [
    { firstName: 'Junaid', lastName: 'Ameen', gender: 'Male', salary: '10000', joindate: new Date("November 23, 2010") },
    { firstName: 'Abdul', lastName: 'kareem', gender: 'Male', salary: '20000', joindate: new Date("March 1, 2009") },
    { firstName: 'Jibran', lastName: 'Ahmed', gender: 'Male', salary: '30000', joindate: new Date("January 2, 2016") },
    { firstName: 'Talha', lastName: '', gender: 'Male', salary: '40000', joindate: new Date("April 3, 2013") },
    { firstName: 'Manha', lastName: 'Fathima', gender: 'Female', salary: '50000', joindate: new Date("May 6, 2015") }
    ];

    $scope.employees = employees;
    $scope.rowLimit = 3;

    $scope.sortColumn = "firstName";

    $scope.reverseSort = false;

    $scope.sortData = function (column) {
        $scope.reverseSort = ($scope.sortColumn == column) ? !$scope.reverseSort : false;
        $scope.sortColumn = column;
    }

    $scope.getSortClass = function (column) {
        if ($scope.sortColumn == column) {
            return $scope.reverseSort ? "arrow-down" : "arrow-up"
        }
        return '';
    }


    $scope.search = function (item) {
        if ($scope.searchtwoProp == undefined) {
            return true;
        }
        else {
            if (item.firstName.toLowerCase().indexOf($scope.searchtwoProp.toLowerCase()) != -1 ||
                item.lastName.toLowerCase().indexOf($scope.searchtwoProp.toLowerCase()) != -1) {
                return true;
            }
        }

        return false;
    }

});


