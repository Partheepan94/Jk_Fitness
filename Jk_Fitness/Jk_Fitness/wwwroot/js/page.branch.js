﻿$(document).ready(function () {
    ListBranchDetails();

});

$('#btnAdd').click(function () {
    $('#BranchModal').modal('show');
    $("#BranchField").css("display", "none");
});


$('#InRangefrom').bind('keyup', function () {
    var RangeFrom = $('#InRangefrom').val();
    if ($.isNumeric(RangeFrom)) {
        $("#Rfrm").css("display", "none");
        $("#btnAddBranch").attr("disabled", false);
    }
    else {
        $("#Rfrm").css("display", "flex");
        $("#btnAddBranch").attr("disabled", true);
    }
});

$('#InRangeTo').bind('keyup', function () {
    var RangeTo = $('#InRangeTo').val();
    if ($.isNumeric(RangeTo)) {
        $("#Rto").css("display", "none");
        $("#btnAddBranch").attr("disabled", false);
    }
    else {
        $("#Rto").css("display", "flex");
        $("#btnAddBranch").attr("disabled", true);
    }
});

$('#MonthRange').bind('keyup', function () {
    var MonthRange = $('#MonthRange').val();
    if ($.isNumeric(MonthRange)) {
        if (MonthRange > 12) {
            $("#ValidRange").css("display", "flex");
            $("#mRange").css("display", "none");
            $("#btnAddBranch").attr("disabled", true);
        }
        else {
            $("#mRange").css("display", "none");
            $("#ValidRange").css("display", "none");
            $("#btnAddBranch").attr("disabled", false);
        }
    }
    else if (!$.isNumeric(MonthRange)) {
        $("#mRange").css("display", "flex");
        $("#ValidRange").css("display", "none");
        $("#btnAddBranch").attr("disabled", true);
    }
});

$('#btnAddBranch').click(function () {
    var Id = $('#BranchId').val();
    var BranchName = $('#Bname').val();
    var RangeFrom = $('#InRangefrom').val();
    var RangeTo = $('#InRangeTo').val();
    var MonthRange = $('#MonthRange').val();

   
    var data = '{"Id": ' + Id +
        ' ,"BranchName":" ' + BranchName +
        ' " ,"MembershipInitialRangeFrom": ' + RangeFrom +
        ' ,"MembershipInitialRangeTo": ' + RangeTo +
        ' ,"MembershipActiveMonthRange": ' + MonthRange + '}';

    if (!$('#Bname').val() || !$('#InRangefrom').val() || !$('#InRangeTo').val() || !$('#MonthRange').val()) {
        Swal.fire({
            icon: 'error',
            title: 'Oops...',
            text: 'Empty Value Can not be Allow!',
        });
    }
    else {
        $("#waitform").css("display", "block");
        $("#btnAddBranch").attr("disabled", true);
        if (Id == "" || Id == "0") {

            $.ajax({
                type: 'POST',
                url: $("#SaveBranch").val(),
                dataType: 'json',
                data: data,
                contentType: 'application/json; charset=utf-8',
                success: function (response) {
                    var myData = jQuery.parseJSON(JSON.stringify(response));
                    $("#waitform").css("display", "none");
                    $("#btnAddBranch").attr("disabled", false);
                    if (myData.code == "1") {
                        Swal.fire({
                            position: 'center',
                            icon: 'success',
                            title: 'Your work has been saved',
                            showConfirmButton: false,
                            timer: 1500
                        });
                        $('#BranchModal').modal('toggle');
                        ListBranchDetails();
                        Clear();
                    } else {
                        Swal.fire({
                            icon: 'error',
                            title: 'Oops...',
                            text: 'Something went wrong!',
                        });
                        Clear();
                    }
                },
                error: function (jqXHR, exception) {
                }
            });

        } else {

            $.ajax({
                type: 'POST',
                url: $("#Updatebranch").val(),
                dataType: 'json',
                data: data,
                contentType: 'application/json; charset=utf-8',
                success: function (response) {
                    var myData = jQuery.parseJSON(JSON.stringify(response));
                    $("#waitform").css("display", "none");
                    $("#btnAddBranch").attr("disabled", false);
                    if (myData.code == "1") {
                        Swal.fire({
                            position: 'center',
                            icon: 'success',
                            title: 'Your work has been Updated',
                            showConfirmButton: false,
                            timer: 1500
                        });
                        $('#BranchModal').modal('toggle');
                        ListBranchDetails();
                        Clear();
                    } else {
                        Swal.fire({
                            icon: 'error',
                            title: 'Oops...',
                            text: 'Something went wrong!',
                        });
                        ListBranchDetails();
                        Clear();
                    }
                },
                error: function (jqXHR, exception) {
                }
            });
        }
    }
});

function ListBranchDetails() {
    $("#wait").css("display", "block");
    $.ajax({
        type: 'GET',
        url: $("#GetBranchDetails").val(),
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        success: function (response) {
            var myData = jQuery.parseJSON(JSON.stringify(response));
            $("#wait").css("display", "none");
            if (myData.code == "1") {
                var ResList = myData.data;
                var tr = [];
                for (var i = 0; i < ResList.length; i++) {
                    tr.push('<tr>');
                    tr.push("<td>" + ResList[i].branchCode + "</td>");
                    tr.push("<td>" + ResList[i].branchName + "</td>");
                    tr.push("<td>" + ResList[i].membershipInitialRangeFrom + " - " + ResList[i].membershipInitialRangeTo +"</td>");
                    tr.push("<td>" + ResList[i].membershipActiveMonthRange + "</td>");
                    tr.push("<td><button onclick=\"EditBranch('" + ResList[i].id + "')\" class=\"btn btn-primary\"><i class=\"fa fa-edit\"></i> Edit </button></td>");
                    if (ResList[i].isDeleteble == true)
                        tr.push("<td><button onclick=\"DeleteBranch('" + ResList[i].id + "')\" class=\"btn btn-danger\"><i class=\"fa fa-trash\"></i> Delete </button></td>")
                    else
                        tr.push("<td><button onclick=\"DeleteBranch('" + ResList[i].id + "')\" class=\"btn btn-danger\" disabled><i class=\"fa fa-trash\"></i> Delete </button></td>")
                    tr.push('</tr>');
                }

                $("#tbodyid").empty();
                $('.tblBranch').append($(tr.join('')));
            } else if (myData.code == "0") {
                Swal.fire({
                    icon: 'error',
                    title: 'Oops...',
                    text: 'No data Found!',
                });

                var tr = [];
                $("#tbodyid").empty();
                $('.tblBranch').append($(tr.join('')));
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

function EditBranch(Id) {
    $('#BranchModal').modal('show');
    $("#BranchField").css("display", "flex");
    $.ajax({
        type: 'POST',
        url: $("#GetBranchById").val(),
        dataType: 'json',
        data: '{"Id": "' + Id + '"}',
        contentType: 'application/json; charset=utf-8',
        success: function (response) {
            var myData = jQuery.parseJSON(JSON.stringify(response));
            if (myData.code == "1") {
                var Result = myData.data;
                $("#BranchId").val(Result['id']);
                $("#Bcode").val(Result['branchCode']);
                $("#Bname").val(Result['branchName']);
                $("#InRangefrom").val(Result['membershipInitialRangeFrom']);
                $("#InRangeTo").val(Result['membershipInitialRangeTo']);
                $("#MonthRange").val(Result['membershipActiveMonthRange']);
                
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


function DeleteBranch(Id) {

    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.value) {
            $("#wait").css("display", "block");
            $.ajax({
                type: 'POST',
                url: $("#DeleteBranch").val(),
                dataType: 'json',
                data: '{"Id": "' + Id + '"}',
                contentType: 'application/json; charset=utf-8',
                success: function (response) {
                    var myData = jQuery.parseJSON(JSON.stringify(response));
                    $("#wait").css("display", "none");
                    if (myData.code == "1") {
                        Swal.fire({
                            title: 'Deleted!',
                            text: 'Your record has been deleted.',
                            icon: 'success',
                        });
                        ListBranchDetails();
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
    })
}


function Clear() {
    $('#BranchId').val('0');
    $('#Bcode').val('');
    $('#Bname').val('');
    $('#InRangefrom').val('');
    $('#InRangeTo').val('');
    $('#MonthRange').val('');
}

function Cancel() {
    $('#BranchModal').modal('toggle');
    ListBranchDetails();
    Clear();
}

$('#btnSearch').click(function () {
    $("#wait").css("display", "block");
    var BrName = $('#BranchName').val();
    var BrCode = $('#BranchCode').val();

    $.ajax({
        type: 'POST',
        url: $("#SearchBranch").val(),
        dataType: 'json',
        data: '{"BranchCode": "' + BrCode + '","BranchName": "' + BrName + '"}',
        contentType: 'application/json; charset=utf-8',
        success: function (response) {
            var myData = jQuery.parseJSON(JSON.stringify(response));
            $("#wait").css("display", "none");
            if (myData.code == "1") {
                var ResList = myData.data;
                var tr = [];
                for (var i = 0; i < ResList.length; i++) {
                    tr.push('<tr>');
                    tr.push("<td>" + ResList[i].branchCode + "</td>");
                    tr.push("<td>" + ResList[i].branchName + "</td>");;
                    tr.push("<td>" + ResList[i].membershipInitialRangeFrom + " - " + ResList[i].membershipInitialRangeTo + "</td>");;
                    tr.push("<td>" + ResList[i].membershipActiveMonthRange + "</td>");;
                    tr.push("<td><button onclick=\"EditBranch('" + ResList[i].id + "')\" class=\"btn btn-primary\"><i class=\"fa fa-edit\"></i> Edit </button></td>");
                    tr.push("<td><button onclick=\"DeleteBranch('" + ResList[i].id + "')\" class=\"btn btn-danger\"><i class=\"fa fa-trash\"></i> Delete </button></td>")
                    tr.push('</tr>');
                }

                $("#tbodyid").empty();
                $('.tblBranch').append($(tr.join('')));
            } else if (myData.code == "0") {
                Swal.fire({
                    icon: 'error',
                    title: 'Oops...',
                    text: 'No data Found!',
                });

                var tr = [];
                $("#tbodyid").empty();
                $('.tblBranch').append($(tr.join('')));
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
});
