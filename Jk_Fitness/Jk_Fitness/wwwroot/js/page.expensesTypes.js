﻿$(document).ready(function () {
    ListExpensesDetails();
});

$('#btnAdd').click(function () {
    $('#ExpensesTypeModal').modal('show');
    $("#ExpenseField").css("display", "none");
});

$('#btnAddExpense').click(function () {
    var Id = $('#ExpenseId').val();
    var ExpenseName = $('#Ename').val();
    var IsEnable = $('#Enabled').prop('checked') ? "true" : "false";

   
    var data = '{"Id": ' + Id +
        ' ,"ExpenseName":"' + ExpenseName + 
        ' ","IsEnable": ' + IsEnable +'}';

    if (!$('#Ename').val()) {
        Swal.fire({
            icon: 'error',
            title: 'Oops...',
            text: 'Empty Value Can not be Allow!',
        });
    }
    else {
        $("#waitform").css("display", "block");
        $("#btnAddExpense").attr("disabled", true);
        if (Id == "" || Id == "0") {

            $.ajax({
                type: 'POST',
                url: $("#SaveExpensesType").val(),
                dataType: 'json',
                data: data,
                contentType: 'application/json; charset=utf-8',
                success: function (response) {
                    var myData = jQuery.parseJSON(JSON.stringify(response));
                    $("#waitform").css("display", "none");
                    $("#btnAddExpense").attr("disabled", false);
                    if (myData.code == "1") {
                        Swal.fire({
                            position: 'center',
                            icon: 'success',
                            title: 'Your work has been saved',
                            showConfirmButton: false,
                            timer: 1500
                        });
                        $('#ExpensesTypeModal').modal('toggle');
                        ListExpensesDetails();
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
                url: $("#UpdateExpenseType").val(),
                dataType: 'json',
                data: data,
                contentType: 'application/json; charset=utf-8',
                success: function (response) {
                    var myData = jQuery.parseJSON(JSON.stringify(response));
                    $("#waitform").css("display", "none");
                    $("#btnAddExpense").attr("disabled", false);
                    if (myData.code == "1") {
                        Swal.fire({
                            position: 'center',
                            icon: 'success',
                            title: 'Your work has been Updated',
                            showConfirmButton: false,
                            timer: 1500
                        });
                        $('#ExpensesTypeModal').modal('toggle');
                        ListExpensesDetails();
                        Clear();
                    } else {
                        Swal.fire({
                            icon: 'error',
                            title: 'Oops...',
                            text: 'Something went wrong!',
                        });
                        ListExpensesDetails();
                        Clear();
                    }
                },
                error: function (jqXHR, exception) {
                }
            });
        }
    }
});

function ListExpensesDetails() {
    $("#wait").css("display", "block");
    $.ajax({
        type: 'GET',
        url: $("#GetExpensesDetails").val(),
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
                    tr.push("<td>" + ResList[i].expenseCode + "</td>");
                    tr.push("<td>" + ResList[i].expenseName + "</td>");
                    if (ResList[i].isEnable == true)
                        tr.push("<td><strong style=\"color:green\">Enabled</strong></td>");
                    else
                        tr.push("<td><strong style=\"color:red\">Disabled</strong></td>");
                    tr.push("<td><button onclick=\"EditExpenseType('" + ResList[i].id + "')\" class=\"btn btn-primary\"><i class=\"fa fa-edit\"></i> Edit </button></td>");
                    tr.push("<td><button onclick=\"DeleteExpenseType('" + ResList[i].id + "')\" class=\"btn btn-danger\"><i class=\"fa fa-trash\"></i> Delete </button></td>")
                    tr.push('</tr>');
                }

                $("#tbodyid").empty();
                $('.tblExpenseTypes').append($(tr.join('')));
            } else if (myData.code == "0") {
                $("#noRecords").css("display", "block");
                $("#tblExpenseTypes").css("display", "none");
                var tr = [];
                $("#tbodyid").empty();
                $('.tblExpenseTypes').append($(tr.join('')));
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

function EditExpenseType(Id) {
    $('#ExpensesTypeModal').modal('show');
    $("#ExpenseField").css("display", "flex");
    $.ajax({
        type: 'POST',
        url: $("#GetExpenseTypeById").val(),
        dataType: 'json',
        data: '{"Id": "' + Id + '"}',
        contentType: 'application/json; charset=utf-8',
        success: function (response) {
            var myData = jQuery.parseJSON(JSON.stringify(response));
            if (myData.code == "1") {
                var Result = myData.data;
                $("#ExpenseId").val(Result['id']);
                $("#Ecode").val(Result['expenseCode']);
                $("#Ename").val(Result['expenseName']);
                $("#Enabled").prop("checked", Result.isEnable)

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

function DeleteExpenseType(Id) {

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
                url: $("#DeleteExpenseType").val(),
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
                        ListExpensesDetails();
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
    $('#ExpenseId').val('0');
    $('#Ecode').val('');
    $('#Ename').val('');
    $('#Status').prop('checked', true);
}

function Cancel() {
    $('#ExpensesTypeModal').modal('toggle');
    ListExpensesDetails();
    Clear();
}

$('#btnSearch').click(function () {
    $("#wait").css("display", "block");
    var ExpName = $('#ExpensesName').val();
    var ExpCode = $('#ExpenseCode').val();

    $.ajax({
        type: 'POST',
        url: $("#SearchExpensesType").val(),
        dataType: 'json',
        data: '{"ExpenseCode": "' + ExpCode + '","ExpenseName": "' + ExpName + '"}',
        contentType: 'application/json; charset=utf-8',
        success: function (response) {
            var myData = jQuery.parseJSON(JSON.stringify(response));
            $("#wait").css("display", "none");
            if (myData.code == "1") {
                var ResList = myData.data;
                var tr = [];
                for (var i = 0; i < ResList.length; i++) {
                    tr.push('<tr>');
                    tr.push("<td>" + ResList[i].expenseCode + "</td>");
                    tr.push("<td>" + ResList[i].expenseName + "</td>");
                    if (ResList[i].isEnable == true)
                        tr.push("<td><strong style=\"color:green\">Enabled</strong></td>");
                    else
                        tr.push("<td><strong style=\"color:red\">Disabled</strong></td>");
                    tr.push("<td><button onclick=\"EditExpenseType('" + ResList[i].id + "')\" class=\"btn btn-primary\"><i class=\"fa fa-edit\"></i> Edit </button></td>");
                    tr.push("<td><button onclick=\"DeleteExpenseType('" + ResList[i].id + "')\" class=\"btn btn-danger\"><i class=\"fa fa-trash\"></i> Delete </button></td>")
                    tr.push('</tr>');
                }

                $("#tbodyid").empty();
                $('.tblExpenseTypes').append($(tr.join('')));
            } else if (myData.code == "0") {
                $("#noRecords").css("display", "block");
                $("#tblExpenseTypes").css("display", "none");
                var tr = [];
                $("#tbodyid").empty();
                $('.tblExpenseTypes').append($(tr.join('')));
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
