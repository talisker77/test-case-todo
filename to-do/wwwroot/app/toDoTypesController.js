(function () {
  'use strict';

  angular
      .module('app')
      .controller('toDoTypesController', function ($scope, $http) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'To do types';
        vm.result = ""
        vm.description = ""

        vm.toDoTypes = [];

        vm.addType = function () {
          $.ajax({
            url: "/api/todotype",
            type: "post",
            data: JSON.stringify({ description: vm.description }),
            contentType: "application/json"
          }).done(function () {
            vm.result = "Type " + vm.description + " added";
            activate();
          });
        }


        activate();

        function activate() {
          $http.get("/api/todotype").then(function (res) {
            vm.toDoTypes = res.data;
          });
        }
      });

})();
