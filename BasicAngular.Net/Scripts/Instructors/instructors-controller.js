"use strict"

//registrationModule.controller("InstructorsController", function ($scope, bootstrappedData) {
//    $scope.instructors = bootstrappedData.instructors;
//});

registrationModule.controller("InstructorsController", function ($scope, instructorRepository) {
    //instructorRepository.get().then(function (instructors) { $scope.instructors = instructors });
    $scope.instructors = instructorRepository.get();
});