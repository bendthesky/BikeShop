/*return $q(function(resolve, reject) {
    // perform some asynchronous operation, resolve or reject the promise when appropriate.
    setInterval(function() {
        if (pollStatus > 0) {
            resolve(polledValue);
        } else if (pollStatus < 0) {
            reject(polledValue);
        } else {
            pollStatus = pollAgain(function(value) {
                polledValue = value;
            });
        }
    }, 10000);
}).
  then(function(value) {
      // handle success
  }, function(reason) {
      // handle failure
  });*/