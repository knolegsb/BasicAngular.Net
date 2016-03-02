
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
        .when('/Registration/CreateAccount', {
            templateUrl: '/templates/create-account.html',
            controller: 'AccountsController'
        })
        .otherwise({ redirectTo: '/' });
        
        //$locationProvider.html5Mode(true);
    });