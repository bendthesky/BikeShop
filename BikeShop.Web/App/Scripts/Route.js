app.config(function ($routeProvider,$httpProvider) {
    $httpProvider.interceptors.push("AuthInterceptor")
    $routeProvider
    .when("/", {
        templateUrl: "/App/Views/Home.html",
        controller: "aHomeController"
    })
    .when("/Details/:id" , {
        templateUrl: "/App/Views/Details.html",
        controller: "DetailsController"
    })
    .when("/List", {
        templateUrl: "/App/Views/Lists.html",
        controller: "aListController"
    })
    .when("/Update", {
        templateUrl: "/App/Views/Update.html",
        controller: "UpdateController"
    })
    .when("/Add", {
        templateUrl: "/App/Views/Add.html",
        controller: "BikeCrudController"
    })
        .when("/Login", {
            templateUrl: "/App/Views/Login.html",
            controller: "LoginController"
        })
        .when("/SignUp", {
            templateUrl: "/App/Views/SignUp.html",
            controller: "LoginController"
        })
        .when("/ContactUs", {
            templateUrl: "/App/Views/ContactUs.html",
            controller: "aContactUsController"
        })
        .when("/HelpRequest", {
            templateUrl: "/App/Views/HelpRequest.html",
            controller: "aHomeController"
        })   
    .otherwise({
        templateUrl: "/App/Views/error.html"
    })
});

