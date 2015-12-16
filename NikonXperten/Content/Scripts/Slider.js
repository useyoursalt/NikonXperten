$(document).ready(function () {

    var amount = $("img", ".SliderWrap").length - 1;
    var width = 960;
    var moved = -960;
    var i = 0;

    window.setInterval(function () {

        if (i == amount) {
            $("#pusher").css({
                "margin-left": "5px"
            })

            moved = 0
            i = -1;
        }

        else {

            $("#pusher").animate({
                "margin-left": moved + "px"
            }, 2000)

            i += 1;
            moved -= 960;

        }

    }, 4000)

})