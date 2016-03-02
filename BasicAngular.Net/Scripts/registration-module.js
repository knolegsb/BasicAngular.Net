
var registrationModule = angular.module("registrationModule", ['ngRoute'])
    .config( function ($routeProvider) {
        $routeProvider
        .when('/Registration/Courses', {
            templateUrl: '/templates/courses.html',
            controller: 'CoursesController'
        })
        .when('/Registration/Instructors', {
            templateUrl: '/templates/instructors.html',
            controller: 'InstructorsController'
        })
        .otherwise({ redirectTo: '/' });
        
        //$locationProvider.html5Mode(true);
    });