var registrationModule = angular.module("registrationModule", ['ngRoute'])
    .config( function ($routeProvider) {
        $routeProvider
        .when('/Registration/Courses', {
            templateUrl: '/templates/courses.html',
            controller: 'CoursesController'
        });
        $routeProvider.when('/Registration/Instructors', {
            templateUrl: '/templates/instructors.html',
            controller: 'InstructorsController'
        });
        $routeProvider.otherwise({ redirectTo: '/' });
        
        //$locationProvider.html5Mode(true);
    });