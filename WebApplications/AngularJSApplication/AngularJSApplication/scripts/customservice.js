/// <reference path="angular.js" />
/// <reference path="common.js" />
myApp.controller("customServiceController", function ($scope, stringService) {

    $scope.reverseString = function (sentence) {
        $scope.reverseSentence = stringService.processString(sentence);
    }
});

myApp.factory('stringService', function () {
    return {

        processString: function (sentence) {

            if (!sentence) {
                return sentence;
            }

            var split = sentence.split(' ');
            var output = "";

            for (var j = split.length; j > 0; j--) {
                output = output + split[j - 1] + " ";
            }

            return output;
        }
    };
});




