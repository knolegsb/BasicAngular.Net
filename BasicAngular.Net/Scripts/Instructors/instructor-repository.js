//registrationModule.factory('instructorRepository', function ($http, $q) {
registrationModule.factory('instructorRepository', function ($resource) {
    return {
        get: function () {
            //var deferred = $q.defer();
            //$http.get('api/Instructors').success(deferred.resolve).error(deferred.reject);
            //return deferred.promise;
            return $resource('/api/Instructors').query();
        }
    }
});