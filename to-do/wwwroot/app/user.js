(function () {
  'use strict';

  angular
      .module('app')
      .controller('User', ["$scope", function ($s) {
        $s.userName = "";
        $s.password = "";
        $s.passwordRepeat = "";
        $s.email = "";
        $s.message = "";
        $s.register = function () {
          if ($s.password == $s.passwordRepeat) {
            var data = {
              "userName": $s.userName,
              "password": $s.password,
              "email": $s.email
            };


            $.ajax({
              url: "/api/user",
              type:"post",
              data: JSON.stringify(data),
              contentType:"application/json"
            }).done(function (res) {
              $s.message = "user " + data.userName + " is registered";
            }).fail(function (err) {
              $s.message = err.responseText ;
            });
          }
        };
      }]);



})();

/*
function user() {
    var vm = this;
    vm = {
      userName: "",
      email: "",
      password: "",
      passwordRepeat: "",
      register: function () {

        debugger;
        if (vm.password == vm.passwordRepeat) {
          $.post("api/user", JSON.stringify(vm)).done(function (res) {
            debugger;
            vm.message = "user " + vm.userName + " is registered";
          }).fail(function () {
            vm.message = "something went wrong";
          });
        }
      },
      message: ""
    };
  };
*/