'use strict'

registrationModule.factory('accountRepository', function ($http) {
    return {
        save: function (student) {
            $http.post('/Accounts/Save', student);
        }
    };
});