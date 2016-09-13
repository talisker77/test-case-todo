// Write your Javascript code.

  (function () {
    var hello = {
      init: function () {
        $.get("api/user/5").done(function (r) {
          
            $("#get").text(r);
          
        });
      }
    };
    hello.init();

    //alert('running');
  })();