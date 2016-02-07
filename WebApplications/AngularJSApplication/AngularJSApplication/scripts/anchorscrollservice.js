/// <reference path="angular.js" />
/// <reference path="common.js" />
myApp.controller("anchorscrollController", function ($scope, $location,$anchorScroll) {
    
    $scope.scrollTo = function (scrollLocation) {

        $location.hash(scrollLocation);
        $anchorScroll.yOffset = 20;
        $anchorScroll();

    }
});


