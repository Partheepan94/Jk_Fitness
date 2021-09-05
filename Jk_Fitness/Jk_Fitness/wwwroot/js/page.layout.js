document.getElementById("Name").innerHTML = JSON.parse(window.localStorage.getItem('Empl')).Name;
var image = JSON.parse(window.localStorage.getItem('Empl')).Image;
var url = window.location.href.split('/', 3).join().replace(",,", "//") + "/dist/img/default.jpg";
if (image != null) {
    $('#UserImg').attr("src", "data:image/jgp;base64," + image + "");
}
else {
    $('#UserImg').attr("src", url);
}
UserRights();
$(function () {
    $('a').each(function () {
        if ($(this).prop('href') == window.location.href) {
            $(this).addClass('active');
            $(this).parents('li').addClass('menu-open');
        } else {
            //$(this).removeClass('active');
        }
    });
});

function SignOut() {
    $.ajax({
        type: 'GET',
        url: $("#SignOutLogin").val(),
        dataType: 'json',
        headers: {
            "Authorization": "Bearer " + sessionStorage.getItem('token'),
        },
        contentType: 'application/json; charset=utf-8',
        success: function (response) {
            var myData = jQuery.parseJSON(JSON.stringify(response));
            if (myData.code == "1") {
                window.localStorage.clear();
                window.location.replace($("#LoginHome").val());
            } else {
                Swal.fire({
                    icon: 'error',
                    title: 'Oops...',
                    text: myData.message,
                });
            }
        },
        error: function (jqXHR, exception) {
        }
    });
}

function UserRights() {
    $.ajax({
        type: 'GET',
        url: $("#GetUserRights").val(),
        dataType: 'json',
        headers: {
            "Authorization": "Bearer " + sessionStorage.getItem('token'),
        },
        contentType: 'application/json; charset=utf-8',
        success: function (response) {
            var myData = jQuery.parseJSON(JSON.stringify(response));
            if (myData.code == "1") {
                var Result = myData.data;
                if (Result[2].role == 1 || Result[2].role == 2)
                    $("#MenuHome").attr('hidden', false);
                else
                    $("#MenuHome").attr('hidden', true);

                if (Result[3].role == 1 || Result[3].role == 2)
                    $("#MenuEmployee").attr('hidden', false);
                else
                    $("#MenuEmployee").attr('hidden', true);

                if (Result[8].role == 1 || Result[8].role == 2)
                    $("#MenuMemebership").attr('hidden', false);
                else
                    $("#MenuMemebership").attr('hidden', true);

                if (Result[13].role == 1 || Result[13].role == 2)
                    $("#MenuAttendance").attr('hidden', false);
                else
                    $("#MenuAttendance").attr('hidden', true);

                if (Result[16].role == 1 || Result[16].role == 2)
                    $("#MenuBranch").attr('hidden', false);
                else
                    $("#MenuBranch").attr('hidden', true);

                if (Result[20].role == 1 || Result[20].role == 2)
                    $("#MenuExpensesType").attr('hidden', false);
                else
                    $("#MenuExpensesType").attr('hidden', true);

                if (Result[24].role == 1 || Result[24].role == 2)
                    $("#MenuMembershipPackage").attr('hidden', false);
                else
                    $("#MenuMembershipPackage").attr('hidden', true);

                if (Result[28].role == 1 || Result[28].role == 2)
                    $("#MenuSalary").attr('hidden', false);
                else
                    $("#MenuSalary").attr('hidden', true);

                if (Result[31].role == 1 || Result[31].role == 2)
                    $("#MenuRights").attr('hidden', false);
                else
                    $("#MenuRights").attr('hidden', true);
            } else {
                Swal.fire({
                    icon: 'error',
                    title: 'Oops...',
                    text: myData.message,
                });
            }
        },
        error: function (jqXHR, exception) {
        }
    });
}
