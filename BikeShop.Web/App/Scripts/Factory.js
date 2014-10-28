app.factory("BikeFactory", function ($http, StoreFactory) {
    return {
        getBikes: function (callback) {
            $http({ method: "GET", url: "/api/ApiBike" })
            .success(function (data) {
               callback(data)
            })
        },
        getBike: function (id, callback) {
            $http({ method: "GET", url: "/api/ApiBike/" + id })
            .success(function (data) {
                callback(data);
            })
        },
        createBike: function (object, callback) {
            console.log(object);
            $http({ method: "POST", url: "/api/ApiBike", data: object })
            .success(function (data) {
                console.log(data);
                location.reload();
            })
            
        }
        /*deleteBike: function (id, callback) {
            $http({ method: "DELETE", url: "/api/ApiBike/" + id })
                .success(function (data) {
                    callback(data);
                })
        }, */
        /*updateBike: function (id, callback) {
            $http({ method: "PUT", url: "/api/ApiBike/" + id })
            .success(function (data) {
                callback(data);
            })
        } */
    }
});

app.factory("StoreFactory", function () {
    var bikes = [];

    
    return {
        bikes: bikes
    };
})

app.factory("PictureFactory", function ($http, BikeFactory) {
    return {
        postPicture: function (id,picture) {
            $http({ method: "POST", url: "/api/ApiPicture/" + id, data: {picture:picture.Url} })
            .success(function () {
                BikeFactory.getBikes();
            })
        }
    }
})

app.factory("commentFactory", function ($http) {
    return {
        postComment: function (callback) {
            $http({ method: "POST", url: "/api/ApiComment/" }) // not sure about url. 
            .success(function (data) {
                callback(data);
            })
        },
        deleteComment: function (id, callback) {
            $http({ method: "DELETE", url: "/api/ApiComment/" + id })
            .success(function (data) {
                callback(data); // need callback??
            })
        }
    }
});

app.factory("SessionHandler", function ($window) {
    var settLoggedInToken = function (token) {
        $window.sessionStorage.setItem("token", token);
    }
    var removeLoggedInToken = function () {
        $window.sessionStorage.removeItem("token");
    }
    return {
        setLoggedInToken: setLoggedInToken,
        removeLoggedInToken: removeLoggedInToken
    }
});

app.factory("LoginService", function ($q, $http, SessionHandler) {
    var processLogin = function (username, password) {
        var deferred = $q.defer();
        $http({
            method: "POST",
            data: "username=" + username + "&password=" + "&grant_type=password",
            headers: { "Content-Type": "application/x-www-form-urlencoded" },
            url: "/Token",
            isArray: false
        }).success(function (data) {
            SessionHandler.setLoggedInToken(data.access_token);
            deferred.resolve();
        }).error(function (data, status) {
            SessionHandler.removeLoggedInToken();
            deferred.reject(status);
        })
        return deferred.promise;
    }
    var processLogout = function () {
        var deferred = $q.defer();
        $http({
            method: "POST",
            url: "/api/Account/Logout"
        }).success(function (data) {
            SessionHandger.removeLoggedIntToken();
            deferred.resolve();
        }).error(function (data, status) {
            deferred.reject(status);
        })
        return deferred.promise;
    }
    return {
        processLogin: processLogin,
        processLogout: processLogout
    }
});

app.factory("AuthInterceptor", function ($window) {
    return {
        request: function (config) {
            config.headers = config.headers || {};
            if ($window.sessionStorage.getItem("token")) {
                config.headers.Authorization = 'Bearer ' + $window.sessionStorage.getItem("token");
            }
            return config;
        }
    }
})