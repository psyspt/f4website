$(document).ready(function() {
    $(".menu > li").click(function(e) {
        switch (e.target.id) {
            case "About":
                //change status & style menu
                $("#About").addClass("active");
                $("#Dshoso").removeClass("active");
                $("#Dscongviec").removeClass("active");

                //display selected division, hide others
                $("div.about").fadeIn();
                $("div.dshoso").css("display", "none");
                $("div.links").css("display", "none");
                break;
            case "Dshoso":
                //change status & style menu
                $("#About").removeClass("active");
                $("#Dshoso").addClass("active");
                $("#Dscongviec").removeClass("active");

                //display selected division, hide others
                $("div.dshoso").fadeIn();
                $("div.about").css("display", "none");
                $("div.dscongviec").css("display", "none");
                break;
            case "Dscongviec":
                //change status & style menu
                $("#About").removeClass("active");
                $("#Dshoso").removeClass("active");
                $("#Dscongviec").addClass("active");

                //display selected division, hide others
                $("div.dscongviec").fadeIn();
                $("div.about").css("display", "none");
                $("div.dshoso").css("display", "none");
                break;
        }
        return false;
    });
});