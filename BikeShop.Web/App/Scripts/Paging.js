/*
app.filter('offset', function () {
    return function (input, start) {
        start = parseInt(start, 10);
        return input.slice(start);
    };
});

app.controller("PaginationCtrl", function ($scope) {
    $scope.itemsPerPage = 5;
    $scope.currentPage = 0;
    $scope.items = [];

    
    $scope.prevPage = function () {
        if ($scope.currentPage > 0) {
            $scope.currentPage--; // ???
        }
    };
    $scope.prevPageDisabled = function () {
        return $scope.currentPage === 0 ? "disabled" : ""; ///???
    };
    $scope.pageCount = function () {
        return Math.ceil($scope.items.length / $scope.itemsPerPage) - 1;
    };
    $scope.nextPage = function () {
        if ($scope.currentPage < $scope.pageCount()) {
            $scope.currentPage++;
        }
    };
    $scope.nextPageDisabled = function () {
        return $scope.currentPage === $scope.pageCount() ? "disabled" : "";

    };
});
*/