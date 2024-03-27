$(function () {
    getClient();
    $("#search").on("keyup", function () {
        var searchtext = $("#search").val().toLowerCase();
        var row = document.getElementById("tbody").children;
        $(row).each(function () {
            if (!Contains($(this).text().toLowerCase(), searchtext)) {
                $(this).hide();
            }
            else {
                $(this).show();
            }
        });
    });
});
function Contains(text_one, text_two) {
    if (text_one.indexOf(text_two) != -1)
        return true;
}
function getClient() {
    $.get("https://localhost:7210/api/client", function (data) {
        var row = "";
        for (var i = 0; i < data.length; i++) {
            row = row
                + "<tr>"
                + "<td>" + data[i].id + "</td>"
                + "<td>" + data[i].firstName + "</td>"
                + "<td>" + data[i].lastName + "</td>"
                + "<td>" + data[i].clientIdNumber + "</td>"
                + "<td>" + `<a href="https://localhost:7094/Account/Select/${data[i].id}" class="btn btn-success">Select</a>` + "</td>"
                + "</tr>";
        };
        $("#tbody").append(row);
        console.log(data);
    });
}