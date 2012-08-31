$(document).ready(function () {
    $("#tabFilter").click(function () {
        $("#pgFilter").show();
        $("#pgTree").hide();
    });

    $("#tabTree").click(function () {
        $("#pgFilter").hide();
        $("#pgTree").show();
    });

    $("#btnFilter").click(function () {
        var filter = $("#txtFilterParam").value();
        var search = $("#txtFilterSearch").value();
        



    });


});

