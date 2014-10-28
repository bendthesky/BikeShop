app.controller("UserController", function ($scope, bikeFactory) {
    $scope.GetBikes = bikeFactory.getBikes();
    $scope.GetBike = bikeFactory.getBike();
});

app.controller("UserCommentController", function () {
    $scope.GetReviews = commentFactory.getReviews();
    $scope.DeleteReview = commentFactory.deleteReivew(id); // not sure here, cuz users can only delete their comments. 
});
