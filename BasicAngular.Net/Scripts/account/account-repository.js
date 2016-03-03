'use strict'

//registrationModule.factory('accountRepository', function ($http, $q) {
registrationModule.factory('accountRepository', function ($resource) {
    return {
        save: function (student) {
            //var deferred = $q.defer();
            //$http.post('/Accounts/Save', student)
            //    .success(function () { deferred.resolve(); })
            //    .error(function () { deferred.reject(); });
            //return deferred.promise;
            return $resource('/Accounts/Save').save(student);
        }
    };
});