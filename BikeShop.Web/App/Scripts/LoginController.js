app.controller("LoginController", function ($scope, $http, $routeParams, $window,
    LoginService, $location) {
    $scope.login = function() {
        LoginService.processLogin($scope.user.UserName, $scope.user.Password).then(
            function() {
                $scope.token = $window.sessionStorage.getItem("token");
                $http({
                    method: "GET",
                    url: "/api/ApiLogin",
                    headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
                }).success(function
                    (boolean) {
                    console.log(boolean)
                    if(boolean == "true"){
                        console.log("Your Boolean is True")
                       $location.path('/Add');
                    }
                    else {
                        $location.path('/');
                    }
                        
                
                })
    }, function (status){
        $scope.token = status;
    })
}
})