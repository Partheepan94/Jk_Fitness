document.getElementById("Name").innerHTML = JSON.parse(window.localStorage.getItem('Empl')).Name;
var image = JSON.parse(window.localStorage.getItem('Empl')).Image;
var url = window.location.href.split('/', 3).join().replace(",,", "//") + "/dist/img/default.jpg";
if (image != null) {
    $('#UserImg').attr("src", "data:image/jgp;base64," + image + "");
}
else {
    $('#UserImg').attr("src", url);
}

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
                    text: 'Something went wrong!',
                });
            }
        },
        error: function (jqXHR, exception) {
        }
    });
}
