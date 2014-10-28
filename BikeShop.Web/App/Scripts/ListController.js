app.controller("aListController", function ($scope, $http, $q, BikeFactory, StoreFactory) {
    var shownBikes = 0;
    $scope.loading = true;
    $scope.$watch.listBikes = [];
    $scope.bikes = StoreFactory.bikes;
    $scope.getBikes = function () {
        var deferred = $q.defer();
        BikeFactory.getBikes(function (data) {
            StoreFactory.bikes = data;
            return $scope.page();
        })

    }
    $scope.page = function (direction) {
        $scope.listBikes = [];
        if (typeof (direction) === "undefined") {
            shownBikes = 0;
        } else if (direction === "next" && shownBikes < StoreFactory.bikes.length - 20) {
            shownBikes += 20;
        } else if (direction === "prev" && shownBikes > 19) {
            shownBikes -= 20;
        }
        for (var i = shownBikes; i < shownBikes + 20; i++) {
            if (typeof (StoreFactory.bikes[i]) === "undefined") {
                break;
            }
            $scope.listBikes.push(StoreFactory.bikes[i]);
        }
        $scope.loading = false;
    }
    $scope.getBikes()

    $scope.brands = [];
})