/// <reference path="../Instructors/instructors-controller.js" />
//registrationModule.factory('courseRepository', function ($http, $q) {
registrationModule.factory('courseRepository', function ($resource) {
    return {
        get: function () {
            //var deferred = $q.defer();
            //$http.get('api/Courses').success(deferred.resolve).error(deferred.reject);
            //return deferred.promise;
            return $resource('api/Courses').query();
        }
    }
});