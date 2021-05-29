$(document).ready(function () {
    ListMembershipDetails();
});

$('#MemAmount').bind('keyup', function () {
    var RangeFrom = $('#MemAmount').val();
    if ($.isNumeric(RangeFrom)) {
        $("#Rfrm").css("display", "none");
        $("#btnAddBranch").attr("disabled", false);
    }
    else {
        $("#Rfrm").css("display", "flex");
        $("#btnAddMembership").attr("disabled", true);
    }
});

$('#btnAdd').click(function () {
    $('#MembershipTypeModal').modal('show');
    $("#MembershipField").css("display", "none");
});

$('#btnAddMembership').click(function () {
    var Id = $('#MembershipId').val();
    var MembershipName = $('#Mname').val();
    var MemAmount = $('#MemAmount').val();
    var IsEnable = $('#Enabled').prop('checked') ? "true" : "false";

   
    var data = '{"Id": ' + Id +
        ' ,"MembershipName":"' + MembershipName + 
        ' ","IsEnable": ' + IsEnable +
        ' ,"MembershipAmount": ' + MemAmount +'}';

    if (!$('#Mname').val() || !$('#MemAmount').val()) {
        Swal.fire({
            icon: 'error',
            title: 'Oops...',
            text: 'Empty Value Can not be Allow!',
        });
    }
    else {
        $("#waitform").css("display", "block");
        $("#btnAddMembership").attr("disabled", true);
        if (Id == "" || Id == "0") {

            $.ajax({
                type: 'POST',
                url: $("#SaveMembershipType").val(),
                dataType: 'json',
                data: data,
                contentType: 'application/json; charset=utf-8',
                success: function (response) {
                    var myData = jQuery.parseJSON(JSON.stringify(response));
                    $("#waitform").css("display", "none");
                    $("#btnAddMembership").attr("disabled", false);
                    if (myData.code == "1") {
                        Swal.fire({
                            position: 'center',
                            icon: 'success',
                            title: 'Your work has been saved',
                            showConfirmButton: false,
                            timer: 1500
                        });
                        $('#MembershipTypeModal').modal('toggle');
                        ListMembershipDetails();
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
                url: $("#UpdateMembershipType").val(),
                dataType: 'json',
                data: data,
                contentType: 'application/json; charset=utf-8',
                success: function (response) {
                    var myData = jQuery.parseJSON(JSON.stringify(response));
                    $("#waitform").css("display", "none");
                    $("#btnAddMembership").attr("disabled", false);
                    if (myData.code == "1") {
                        Swal.fire({
                            position: 'center',
                            icon: 'success',
                            title: 'Your work has been Updated',
                            showConfirmButton: false,
                            timer: 1500
                        });
                        $('#MembershipTypeModal').modal('toggle');
                        ListMembershipDetails();
                        Clear();
                    } else {
                        Swal.fire({
                            icon: 'error',
                            title: 'Oops...',
                            text: 'Something went wrong!',
                        });
                        ListMembershipDetails();
                        Clear();
                    }
                },
                error: function (jqXHR, exception) {
                }
            });
        }
    }
});

function ListMembershipDetails() {
    $("#wait").css("display", "block");
    $.ajax({
        type: 'GET',
        url: $("#GetMembershipTypeDetails").val(),
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
                    tr.push("<td>" + ResList[i].membershipCode + "</td>");
                    tr.push("<td>" + ResList[i].membershipName + "</td>");
                    tr.push("<td>" + ResList[i].membershipAmount.toFixed(2) + "</td>");
                    if (ResList[i].isEnable == true)
                        tr.push("<td><strong style=\"color:green\">Enabled</strong></td>");
                    else
                        tr.push("<td><strong style=\"color:red\">Disabled</strong></td>");
                    tr.push("<td><button onclick=\"EditMembershipType('" + ResList[i].id + "')\" class=\"btn btn-primary\"><i class=\"fa fa-edit\"></i> Edit </button></td>");
                    tr.push("<td><button onclick=\"DeleteMembershipType('" + ResList[i].id + "')\" class=\"btn btn-danger\"><i class=\"fa fa-trash\"></i> Delete </button></td>")
                    tr.push('</tr>');
                }

                $("#tbodyid").empty();
                $('.tblMembershipTypes').append($(tr.join('')));
            } else if (myData.code == "0") {
                $("#noRecords").css("display", "block");
                $("#tblMembershipTypes").css("display", "none");
                var tr = [];
                $("#tbodyid").empty();
                $('.tblMembershipTypes').append($(tr.join('')));
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

function EditMembershipType(Id) {
    $('#MembershipTypeModal').modal('show');
    $("#MembershipField").css("display", "flex");
    $.ajax({
        type: 'POST',
        url: $("#GetMembershipTypeById").val(),
        dataType: 'json',
        data: '{"Id": "' + Id + '"}',
        contentType: 'application/json; charset=utf-8',
        success: function (response) {
            var myData = jQuery.parseJSON(JSON.stringify(response));
            if (myData.code == "1") {
                var Result = myData.data;
                $("#MembershipId").val(Result['id']);
                $("#Mcode").val(Result['membershipCode']);
                $("#Mname").val(Result['membershipName']);
                $("#MemAmount").val(Result['membershipAmount'].toFixed(2));
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

function DeleteMembershipType(Id) {

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
                url: $("#DeleteMembershipType").val(),
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
                        ListMembershipDetails();
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
    $('#MembershipId').val('0');
    $('#Mcode').val('');
    $('#Mname').val('');
    $('#MemAmount').val('');
    $('#Status').prop('checked', true);
}

function Cancel() {
    $('#MembershipTypeModal').modal('toggle');
    ListMembershipDetails();
    Clear();
}

$('#btnSearch').click(function () {
    $("#wait").css("display", "block");
    var MemName = $('#MembershipName').val();
    var MemCode = $('#MembershipCode').val();

    $.ajax({
        type: 'POST',
        url: $("#SearchMembershipType").val(),
        dataType: 'json',
        data: '{"MembershipCode": "' + MemCode + '","MembershipName": "' + MemName + '"}',
        contentType: 'application/json; charset=utf-8',
        success: function (response) {
            var myData = jQuery.parseJSON(JSON.stringify(response));
            $("#wait").css("display", "none");
            if (myData.code == "1") {
                var ResList = myData.data;
                var tr = [];
                for (var i = 0; i < ResList.length; i++) {
                    tr.push('<tr>');
                    tr.push("<td>" + ResList[i].membershipCode + "</td>");
                    tr.push("<td>" + ResList[i].membershipName + "</td>");
                    tr.push("<td>" + ResList[i].membershipAmount.toFixed(2) + "</td>");
                    if (ResList[i].isEnable == true)
                        tr.push("<td><strong style=\"color:green\">Enabled</strong></td>");
                    else
                        tr.push("<td><strong style=\"color:red\">Disabled</strong></td>");
                    tr.push("<td><button onclick=\"EditMembershipType('" + ResList[i].id + "')\" class=\"btn btn-primary\"><i class=\"fa fa-edit\"></i> Edit </button></td>");
                    tr.push("<td><button onclick=\"DeleteMembershipType('" + ResList[i].id + "')\" class=\"btn btn-danger\"><i class=\"fa fa-trash\"></i> Delete </button></td>")
                    tr.push('</tr>');
                }

                $("#tbodyid").empty();
                $('.tblMembershipTypes').append($(tr.join('')));
            } else if (myData.code == "0") {
                $("#noRecords").css("display", "block");
                $("#tblMembershipTypes").css("display", "none");
                var tr = [];
                $("#tbodyid").empty();
                $('.tblMembershipTypes').append($(tr.join('')));
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
