
$(document).ready(function () {

    $("#toggle").click(function () {
        $(".searchbar").slideToggle();
        
    })

    $("#Sport").click(function () {

        $("#Sporttab").addClass("active in");
        $("#Musicaltab").removeClass("active");
        $("#Movietab").removeClass("active");
        $("#Newtab").removeClass("active");
    })

    $("#Musical").click(function () {

        $("#Sporttab").removeClass("active");
        $("#Musicaltab").addClass("active in");
        $("#Movietab").removeClass("active");
        $("#Newtab").removeClass("active");
    })

    $("#Movie").click(function () {

        $("#Sporttab").removeClass("active");
        $("#Musicaltab").removeClass("active");
        $("#Newtab").removeClass("active");
        $("#Movietab").addClass("active in");
    })
    $("#NewComing").click(function () {
        $("#Sporttab").removeClass("active");
        $("#Musicaltab").removeClass("active");
        $("#Movietab").removeClass("active");
        $("#Newtab").addClass("active in")
    })

});