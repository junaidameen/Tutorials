myApp.controller("eventHandleController", function ($scope) {

    var technologies = [
        { name: 'C#', likes: 0, dislikes: 0 },
        { name: 'Java', likes: 0, dislikes: 0 },
        { name: 'AngularJS', likes: 0, dislikes: 0 }
    ];

    $scope.technologies = technologies;

    $scope.incrementLikes = function (technology) {
        technology.likes++;
    }

    $scope.incrementDislikes = function (technology) {
        technology.dislikes++;
    }


});

