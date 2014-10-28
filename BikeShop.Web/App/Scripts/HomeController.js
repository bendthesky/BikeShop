app.controller("aHomeController", function ($scope, $http, BikeFactory, StoreFactory) {

    //Paging code starts here. Put me in your controller with the needed above dependences. BikeFactory houses my AJAX calls, and StoreFactory is just a factory with and empty array in it (StoreFactory.bikes)
    var shownBikes = 0;
    $scope.pageArray = [];
    $scope.loading = true; //For "Loading" placeholder in DOM
    $scope.showcaseBikes = []; //For ng-repeat in DOM
    $scope.bikes = StoreFactory.bikes;
    $scope.getBikes = function () {
        BikeFactory.getBikes(function (data) {
            StoreFactory.bikes = data;
            return $scope.page(); // Once the bikes are loaded, start the paging
        })

    }
    $scope.page = function (direction) {
        var pageCount = 0;
        $scope.pageArray = []; // The array of numbers that will represent the number of pages on the DOM, ng-repeat
        for (var i = 0; i < StoreFactory.bikes.length; i++) {
            if (i % 3 === 0) { //The number three corresponds with how many items you want to appear at a time
                pageCount++;
                $scope.pageArray.push({
                    pageNum: pageCount,
                    iter: i
                });
            }
        }
        $scope.showcaseBikes = [];
        if (typeof (direction) === "undefined") {
            shownBikes = 0;
        } else if (typeof (direction) === "number") {
            shownBikes = direction;
        } else if (direction === "next" && shownBikes < StoreFactory.bikes.length - 3) {
            shownBikes += 3;
            // If user hits "next" button and we're not at the end of the array, load three more
        } else if (direction === "prev" && shownBikes > 2) {
            shownBikes -= 3;
            // If user hits "prev" button and we're not at the beginning of the array, load the three previous
        }
        for (var i = shownBikes; i < shownBikes + 3; i++) {
            if (typeof (StoreFactory.bikes[i]) === "undefined") {
                break;
                // This allows you to get to the end of your array without worrying if your amount of data is evenly divisible by te amount you want to page. So if you're paging 20 items at a time and you get to the last page that only has 5, you won't get 15 slots of undefined.
            }
            $scope.showcaseBikes.push(StoreFactory.bikes[i]);
        }
        $scope.loading = false;
    }
    $scope.getBikes();
});

//sorting

//searching

//paging 