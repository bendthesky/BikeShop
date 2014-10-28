app.controller("UpdateController", function () {
    $scope.updateBike(id, function () {
        $http({ method: "PUT", url: "/api/ApiBike/Details/" + id })
        .success(function (data) {
            $scope.updatedBike = data;
        }) 
    }); 
})

