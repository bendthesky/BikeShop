app.controller("BikeCrudController", function ($location, $scope, $http, BikeFactory, PictureFactory, StoreFactory) {
    $scope.Picture = {};

    BikeFactory.getBikes(function (data) {
        $scope.bikes = data;
    });

    $scope.createBike = function () {
        console.log($scope.bike.Picture);
        console.log($scope.bike.Id);
        BikeFactory.createBike($scope.bike);
        BikeFactory.getBikes(function (data) {
            $scope.$watch.bikes = data;
        });
        
    };
    $scope.addPicture = function () {
        var id =
        PictureFactory.postPicture($scope.bikes[$scope.bikes.length - 1].Id, $scope.Picture);
        $scope.bikes[$scope.bikes.length -1].Url = $scope.Picture.Url;
        $("#modal").modal();
    }
    
    /*$scope.createBike = function () {
        $http({ method: "POST", url: "/api/ApiBike", data: $scope.Bike })
       .success(function (data) {
           console.log(data);
           if (data > 0) {
               
               BikeFactory.getBikes();
               location.reload();
           }
       })
    }*/
    $scope.deleteBike = function (id) {
        $http({ method: "DELETE", url: "/api/ApiBike/" + id })
            .success(function (data) {
                location.reload();
                //$scope.getBikes();
                //$scope.bikes.pop(id);
               // $location.path("/Add")
               // $scope.BikeFactory.getBikes();
            })
    };
    $scope.updateBike = function (id) {

        $http({ method: "PUT", url: "/api/ApiBike/" + id, data: $scope.bike })
        .success(function (data) {
            location.reload();
            $("#modal").modal('hide');
        })
    }
    $scope.showBike = function (id) {
        $scope.content = true;
        $scope.thePictures = false;
        BikeFactory.getBike(id, $("#modal").modal()
            //function (data) {
            //$scope.bike = data;
        );

        //$("#modal").modal();
        //document.getElementById("editBrand").value = $scope.bike.Brand;
        //document.getElementById("editModel").value = bike.Model;
        //document.getElementById("editType").value = bike.Type;
        //document.getElementById("editPrice").value = bike.Price;
    }
})
