(function () {
    'use strict';

    angular
        .module('app')
        .controller('reportsController', reportsController);

    reportsController.$inject = ['$location']; 

    function reportsController($location) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'reportsController';

        activate();

        function activate() { }
    }
})();
