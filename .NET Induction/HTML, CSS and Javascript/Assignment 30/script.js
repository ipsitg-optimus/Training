
$(document).ready(function () {
    $(".option").click(function () {
        //if a exclusive item is checked
        if ($(this).attr("id") == 'exclusive') {
            if ($(this).children().prop("checked")) {
                $(this).children().prop("checked", false);
                $(this).children().css("color", "black");
                $(this).removeClass("option-selected");
                $(this).addClass("option");
            }
            else {
                $("div > input").prop("checked", false);
                $("#question>div").children().css("color", "black");
                $("#question>div").removeClass("option-selected");
                $("#question>div").addClass("option");

                $(this).children().prop("checked", true);
                $(this).children().css("color", "white");
                $(this).removeClass("option");
                $(this).addClass("option-selected");
            }
        }
        else {
            if ($(this).children().prop("checked")) {
                $(this).children().prop("checked", false);
                $(this).children().css("color", "black");
                $(this).removeClass("option-selected");
                $(this).addClass("option");
            }
            else {
                $(this).children().prop("checked", true);
                $(this).children().css("color", "white");
                $(this).removeClass("option");
                $(this).addClass("option-selected");
            }
        }
    });
});