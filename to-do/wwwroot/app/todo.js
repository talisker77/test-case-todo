(function () {
  'use strict';

  angular
      .module('app')
      .controller('ToDo', function ($scope, $http) {
        var vm = this;
        vm.user = {};
        vm.users = [];
        vm.todoItems = [];
        vm.todoTypes = [];
        vm.title = "";
        vm.todoType = {};
        vm.description = "";
        vm.message = "loading...";
        var getToDo = function () {
          $http.get("/api/todo").then(function (res) {
            vm.todoItems = res.data;
            vm.message = "loaded";
          });
        };

        getToDo();
        $http.get("/api/todotype").then(function (res) {
          vm.todoTypes = res.data;
        });

        $http.get("/api/user").then(function (res) {
          vm.users = res.data;
        });

        vm.addToDo = function () {
          $http.post("/api/todo", {

            userName: vm.user.userName, toDoItems: [{
              title: vm.title,
              description: vm.description,
              toDoType: vm.todoType
            }]
          }).then(function () {
            getToDo();
          });
        }
      });

})();