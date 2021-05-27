$(document).ready(function () {
    ListEmployeeDetails();
    LoadBranchesforSearch();

});

//for Time Picker
    $(function () {
        //Date picker
        $('#timepicker').datetimepicker({
            format: 'LT'
        })
        $('#timepicker1').datetimepicker({
            format: 'LT'
        })
        $('#timepicker2').datetimepicker({
            format: 'LT'
        })
        $('#timepicker3').datetimepicker({
            format: 'LT'
        })
    });

$('#btnAdd').click(function () {
    $('#EmpModal').modal('show');
    LoadBranches();
    LoadUserTypes();
    LoadSalutation();
    $("#Branch").attr("disabled", false);
});

function ListEmployeeDetails() {
    $("#wait").css("display", "block");
    $.ajax({
        type: 'GET',
        url: $("#GetEmployeeDetailsPath").val(),
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        success: function (response) {
            var myData = jQuery.parseJSON(JSON.stringify(response));
            $("#wait").css("display", "none");
            if (myData.code == "1") {
                var EmpList = myData.data;
                var tr = [];
                for (var i = 0; i < EmpList.length; i++) {
                    tr.push('<tr>');
                    tr.push("<td>" + EmpList[i].employeeId + "</td>");
                    tr.push("<td>" + EmpList[i].firstName + "</td>");;
                    tr.push("<td>" + EmpList[i].lastName + "</td>");;
                    tr.push("<td>" + EmpList[i].branch + "</td>");;
                    tr.push("<td>" + EmpList[i].userType + "</td>");;
                    tr.push("<td>" + EmpList[i].active + "</td>");;
                    tr.push("<td><button onclick=\"EditEmployee('" + EmpList[i].employeeId + "')\" class=\"btn btn-primary\"><i class=\"fa fa-edit\"></i> Edit </button></td>");
                    tr.push("<td><button onclick=\"DeleteEmployee('" + EmpList[i].employeeId + "')\" class=\"btn btn-danger\"><i class=\"fa fa-trash\"></i> Delete </button></td>")
                    tr.push('</tr>');
                }

                $("#tbodyid").empty();
                $('.tblEmployee').append($(tr.join('')));
            } else if (myData.code == "0") {
                Swal.fire({
                    icon: 'error',
                    title: 'Oops...',
                    text: 'No data Found!',
                });

                var tr = [];
                $("#tbodyid").empty();
                $('.tblEmployee').append($(tr.join('')));
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

function LoadBranches() {
    $('#Branch').find('option').remove().end();
    Branch = $('#Branch');

    $.ajax({
        type: 'GET',
        url: $("#GetBranchDetails").val(),
        dataType: 'json',
        headers: {
            "Authorization": "Bearer " + sessionStorage.getItem('token'),
        },
        contentType: 'application/json; charset=utf-8',
        success: function (response) {
            var myData = jQuery.parseJSON(JSON.stringify(response));
            if (myData.code == "1") {
                var Result = myData.data;
                Branch.append($("<option/>").val(0).text("-Select Branch-"));
                $.each(Result, function () {
                    Branch.append($("<option/>").val(this.branchName).text(this.branchName));
                });
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

function LoadUserTypes() {
    $('#UserType').find('option').remove().end();
    UserType = $('#UserType');

    $.ajax({
        type: 'GET',
        url: $("#GetUserTypeDetails").val(),
        dataType: 'json',
        headers: {
            "Authorization": "Bearer " + sessionStorage.getItem('token'),
        },
        contentType: 'application/json; charset=utf-8',
        success: function (response) {
            var myData = jQuery.parseJSON(JSON.stringify(response));
            if (myData.code == "1") {
                var Result = myData.data;
                UserType.append($("<option/>").val(0).text("-Select UserType-"));
                $.each(Result, function () {
                    UserType.append($("<option/>").val(this.role).text(this.role));
                });
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

function LoadSalutation() {
    $('#Salutation').find('option').remove().end();
    Salutation = $('#Salutation');
    var SalutationList = [
        { Id: 1, Name: "Mr" },
        { Id: 2, Name: "Mrs" },
        { Id: 3, Name: "Ms" },
        { Id: 4, Name: "Miss" },
        { Id: 5, Name: "Dr" },
        { Id: 5, Name: "Professor" }
    ];
    Salutation.append($("<option/>").val(0).text("-Select Salutation-"))
    $.each(SalutationList, function () {
        Salutation.append($("<option/>").val(this.Name).text(this.Name));
    });
}


$('#btnAddEmployee').click(function () {

    var EmployeeId = $('#EmployeeId').val();
    var Salutation = $('#Salutation').val();
    var Fname = $('#Fname').val();
    var Lname = $('#Lname').val();
    var Address = $('#Address').val();
    var Email = $('#Email').val();
    var ContactNo = $('#ContactNo').val();
    var Branch = $('#Branch').val();
    var UserType = $('#UserType').val();
    var MorningIn = $('#MorningIn').val();
    var MorningOut = $('#MorningOut').val();
    var EveningIn = $('#EveningIn').val();
    var EveningOut = $('#EveningOut').val();
    var Active = $('#Status').prop('checked') ? "true" : "false";
    var filter = /^[0][0-9]{9}$/;

    var Mailregex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;

    var data = '{"EmployeeId": "' + EmployeeId +
        ' ","Salutation": "' + Salutation +
        ' " ,"FirstName":" ' + Fname +
        ' " ,"LastName":" ' + Lname +
        ' ","Address":" ' + Address +
        ' " ,"Email":" ' + Email +
        ' ","PhoneNo":" ' + ContactNo +
        ' ","Branch": " ' + Branch +
        ' ","UserType":" ' + UserType +
        ' ","Active": ' + Active +
        ',"MorningInTime": "' + MorningIn +
        ' ","MorningOutTime": "' + MorningOut +
        ' ","EveningInTime": "' + EveningIn +
        ' ","EveningOutTime": "' + EveningOut + '"}';

    if (!$('#Fname').val() || !$('#Lname').val() || !$('#Address').val() || !$('#MorningIn').val() || !$('#MorningOut').val() || !$('#EveningIn').val() || !$('#EveningOut').val()) {
        Swal.fire({
            icon: 'error',
            title: 'Oops...',
            text: 'Empty Value Can not be Allow!',
        });
    }
    else if (!Mailregex.test(Email)) {
        Swal.fire({
            icon: 'error',
            title: 'Oops...',
            text: 'Please enter a vaild email address!',
        });
    } else if (!filter.test(ContactNo)) {
        Swal.fire({
            icon: 'error',
            title: 'Oops...',
            text: 'Please enter a vaild Phone No!',
        });
    } else if (Salutation == 0 || Branch == 0 || UserType == 0) {
        Swal.fire({
            icon: 'error',
            title: 'Oops...',
            text: 'Please Select a Value!',
        });
    } else {
        $("#waitform").css("display", "block");
        $("#btnAddEmployee").attr("disabled", true);
        if (EmployeeId == "0" || EmployeeId == "") {

            $.ajax({
                type: 'POST',
                url: $("#SaveEmployees").val(),
                dataType: 'json',
                data: data,
                contentType: 'application/json; charset=utf-8',
                success: function (response) {
                    var myData = jQuery.parseJSON(JSON.stringify(response));
                    $("#waitform").css("display", "none");
                    $("#btnAddEmployee").attr("disabled", false);
                    if (myData.code == "1") {
                        Swal.fire({
                            position: 'center',
                            icon: 'success',
                            title: 'Your work has been saved',
                            showConfirmButton: false,
                            timer: 1500
                        });
                        $('#EmpModal').modal('toggle');
                        ListEmployeeDetails();
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

        }
        else {

            $.ajax({
                type: 'POST',
                url: $("#UpdateEmployees").val(),
                dataType: 'json',
                data: data,
                contentType: 'application/json; charset=utf-8',
                success: function (response) {
                    var myData = jQuery.parseJSON(JSON.stringify(response));
                    $("#waitform").css("display", "none");
                    $("#btnAddEmployee").attr("disabled", false);
                    if (myData.code == "1") {
                        Swal.fire({
                            position: 'center',
                            icon: 'success',
                            title: 'Your work has been Updated',
                            showConfirmButton: false,
                            timer: 1500
                        });
                        $('#EmpModal').modal('toggle');
                        ListEmployeeDetails();
                        Clear();
                    } else {
                        Swal.fire({
                            icon: 'error',
                            title: 'Oops...',
                            text: 'Something went wrong!',
                        });
                        ListEmployeeDetails();
                        Clear();
                    }
                },
                error: function (jqXHR, exception) {
                }
            });

        }

    }

});

function EditEmployee(Id) {
    $('#EmpModal').modal('show');
    LoadBranches();
    LoadUserTypes();
    LoadSalutation();
    $("#Branch").attr("disabled", true);
    $.ajax({
        type: 'POST',
        url: $("#GetEmployeeById").val(),
        dataType: 'json',
        data: '{"EmployeeId": "' + Id + '"}',
        contentType: 'application/json; charset=utf-8',
        success: function (response) {
            var myData = jQuery.parseJSON(JSON.stringify(response));
            if (myData.code == "1") {
                var Result = myData.data;
                $("#Salutation").val(Result['salutation']);
                $("#Fname").val(Result['firstName']);
                $("#Lname").val(Result['lastName']);
                $("#Address").val(Result['address']);
                $("#Email").val(Result['email']);
                $("#ContactNo").val(Result['phoneNo']);
                $("#Branch").val(Result['branch']);
                $("#UserType").val(Result['userType']);
                $("#MorningIn").val(Result['morningInTime']);
                $("#MorningOut").val(Result['morningOutTime']);
                $("#EveningIn").val(Result['eveningInTime']);
                $("#EveningOut").val(Result['eveningOutTime']);
                $("#Status").prop("checked", Result.active)
                $("#EmployeeId").val(Result['employeeId']);
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

function DeleteEmployee(Id) {

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
                url: $("#DeleteEmployees").val(),
                dataType: 'json',
                data: '{"EmployeeId": "' + Id + '"}',
                contentType: 'application/json; charset=utf-8',
                success: function (response) {
                    $("#wait").css("display", "none");
                    var myData = jQuery.parseJSON(JSON.stringify(response));
                    if (myData.code == "1") {
                        Swal.fire({
                            title: 'Deleted!',
                            text: 'Your record has been deleted.',
                            icon: 'success',
                        });
                        ListEmployeeDetails();
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

function LoadBranchesforSearch() {
    $('#BranchforSearch').find('option').remove().end();
    BranchforSearch = $('#BranchforSearch');

    $.ajax({
        type: 'GET',
        url: $("#GetBranchDetails").val(),
        dataType: 'json',
        headers: {
            "Authorization": "Bearer " + sessionStorage.getItem('token'),
        },
        contentType: 'application/json; charset=utf-8',
        success: function (response) {
            var myData = jQuery.parseJSON(JSON.stringify(response));
            if (myData.code == "1") {
                var Result = myData.data;
                BranchforSearch.append($("<option/>").val(0).text("-Select Branch-"));
                $.each(Result, function () {
                    BranchforSearch.append($("<option/>").val(this.branchName).text(this.branchName));
                });
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

$('#btnSearch').click(function () {
    $("#wait").css("display", "block");
    var Branch = $('#BranchforSearch').val();
    var FName = $('#NameforSearch').val();

    $.ajax({
        type: 'POST',
        url: $("#SearchEmployees").val(),
        dataType: 'json',
        data: '{"FirstName": "' + FName + '","Branch": "' + Branch + '"}',
        contentType: 'application/json; charset=utf-8',
        success: function (response) {
            var myData = jQuery.parseJSON(JSON.stringify(response));
            $("#wait").css("display", "none");
            if (myData.code == "1") {
                var EmpList = myData.data;
                var tr = [];
                for (var i = 0; i < EmpList.length; i++) {
                    tr.push('<tr>');
                    tr.push("<td>" + EmpList[i].employeeId + "</td>");
                    tr.push("<td>" + EmpList[i].firstName + "</td>");;
                    tr.push("<td>" + EmpList[i].lastName + "</td>");;
                    tr.push("<td>" + EmpList[i].branch + "</td>");;
                    tr.push("<td>" + EmpList[i].userType + "</td>");;
                    tr.push("<td>" + EmpList[i].active + "</td>");;
                    tr.push("<td><button onclick=\"EditEmployee('" + EmpList[i].employeeId + "')\" class=\"btn btn-primary\"><i class=\"fa fa-edit\"></i> Edit </button></td>");
                    tr.push("<td><button onclick=\"DeleteEmployee('" + EmpList[i].employeeId + "')\" class=\"btn btn-danger\"><i class=\"fa fa-trash\"></i> Delete </button></td>")
                    tr.push('</tr>');
                }

                $("#tbodyid").empty();
                $('.tblEmployee').append($(tr.join('')));
            } else if (myData.code == "0") {
                Swal.fire({
                    icon: 'error',
                    title: 'Oops...',
                    text: 'No data Found!',
                });

                var tr = [];
                $("#tbodyid").empty();
                $('.tblEmployee').append($(tr.join('')));
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

function Clear() {
    $('#EmployeeId').val('');
    $('#Salutation').val('');
    $('#Fname').val('');
    $('#Lname').val('');
    $('#Address').val('');
    $('#Email').val('');
    $('#ContactNo').val('');
    $('#Branch').val('');
    $('#UserType').val('');
    $('#MorningIn').val('');
    $('#MorningOut').val('');
    $('#EveningIn').val('');
    $('#EveningOut').val('');
    $('#Status').prop('checked', true);
}

function Cancel() {
    $('#EmpModal').modal('toggle');
    ListEmployeeDetails();
    Clear();
}
