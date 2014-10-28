app.controller("DetailsController", function ($http, $scope, BikeFactory, $routeParams, $location){
    
    BikeFactory.getBike($routeParams.id, function (data) {  // Get all the detail info
        $scope.bike = data;
    });
    $scope.createComment = function (id) {
        $http({ method: "POST", url: "/api/ApiComment/" + $routeParams.id , data: $scope.Comment })
        .success(function (data) {    
                console.log(data);
                location.reload();
                //$scope.BikeFactory.getBike($routeParams.id);
            
        })
    };
    $scope.deleteComment = function (id) {
        $http({ method: "DELETE", url: "/api/ApiComment/" + $routeParams.id })
        .success(function (data) {
            $scope.bike = data;

            location.reload();
        })
    }
    
})


