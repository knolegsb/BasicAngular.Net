'use strict'

registrationModule.controller("AccountsController", function ($scope, accountRepository) {
    $scope.save = function (student) {
        accountRepository.save(student);
    };
});