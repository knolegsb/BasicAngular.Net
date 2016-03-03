//registrationModule.controller("CoursesController", function ($scope, bootstrappedData) {
//    $scope.courses = bootstrappedData.courses;
//});
//"use strict"

registrationModule.controller("CoursesController", function ($scope, courseRepository) {
    //$scope.courses = bootstrappedData.courses;
    //courseRepository.get().then(function (courses) { $scope.courses = courses; });
    $scope.courses = courseRepository.get();
});