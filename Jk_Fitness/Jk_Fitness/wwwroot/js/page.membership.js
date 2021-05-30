$(document).ready(function () {
    ListMemberDetails();
    LoadBranchesforSearch();
});

$('#btnAdd').click(function () {
    $('#MemberModal').modal('show');
    LoadBranches();
    LoadGender();
    LoadMemberShipType();
});

$(function () {
    //Date picker
    $('#fromdate').datetimepicker({
        format: 'L'
    })
    $('#Jdate').datetimepicker({
        format: 'L'
    })
});

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

function LoadMemberShipType() {
    $('#Package').find('option').remove().end();
    Package = $('#Package');

    $.ajax({
        type: 'GET',
        url: $("#GetMembershipTypeDetails").val(),
        dataType: 'json',
        headers: {
            "Authorization": "Bearer " + sessionStorage.getItem('token'),
        },
        contentType: 'application/json; charset=utf-8',
        success: function (response) {
            var myData = jQuery.parseJSON(JSON.stringify(response));
            if (myData.code == "1") {
                var Result = myData.data;
                Package.append($("<option/>").val(0).text("-Select Membersip Type-"));
                $.each(Result, function () {
                    Package.append($("<option/>").val(this.id).text(this.membershipName));
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

function LoadMemberShipAmount() {
    var Id = $('#Package').val();
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
                 $("#Payment").val(Result['membershipAmount'].toFixed(2));

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

function LoadGender() {
    $('#Gender').find('option').remove().end();
    Gender = $('#Gender');
    var GenderList = [
        { Id: 1, Name: "Male" },
        { Id: 2, Name: "Female" },
        { Id: 3, Name: "Other" },
    ];
    Gender.append($("<option/>").val(0).text("-Select Gender-"))
    $.each(GenderList, function () {
        Gender.append($("<option/>").val(this.Name).text(this.Name));
    });
}

function MemberShipPackage() {
    $('#Package').find('option').remove().end();
    Package = $('#Package');

    var Package_Type = [
        { Id: 1, Name: "Monthly" },
        { Id: 2, Name: "Quarterly" },
        { Id: 3, Name: "HalfYearly" },
        { Id: 4, Name: "Yearly" }
    ];

    Package.append($("<option/>").val(0).text("-Select Season Type-"))
    $.each(Package_Type, function () {
        Package.append($("<option/>").val(this.Id).text(this.Name));
    });
}

$('#btnAddMember').click(function () {

    var Memberid = $('#MembershipId').val();
    var FirstName = $('#Fname').val();
    var latName = $('#Lname').val();
    var Gender = $('#Gender').val();
    var Nic = $('#Nic').val();
    var Branch = $('#Branch').val();
    var ContactNo = $('#ContactNo').val();
    var DOB = new Date($('#DOB').val());
    var Email = $('#Email').val();
    var Age = $('#Age').val();
    var Height = $('#Height').val();
    var Weight = $('#Weight').val();
    var Address = $('#Address').val();
    var PMCondition = $('#PMCondition').val();
    var Training = $('#Training').val();
    var Package = $('#Package').val();
    var Joindate = new Date($('#JoinDate').val());
    var Payment = $('#Payment').val();
    var Introduce = $('#Introduce').val();
    var EmergencyTP = $('#EmergencyTP').val();
    var Relation = $('#Relation').val();
    var Active = $('#Status').prop('checked') ? "true" : "false";

    var filter = /^[0][0-9]{9}$/;

    var Mailregex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;

    var data = '{"MemberId": ' + Memberid +
        ' ,"FirstName": "' + FirstName +
        ' " ,"LastName":" ' + latName +
        ' " ,"Gender":" ' + Gender +
        ' ","NIC":" ' + Nic +
        ' " ,"Address":" ' + Address +
        ' ","ContactNo":" ' + ContactNo +
        ' ","DateofBirth": ' + JSON.stringify(DOB) +
        ' ,"Email":" ' + Email +
        ' ","Branch":" ' + Branch +
        ' ","Age": ' + Age +
        ',"Height": ' + Height +
        ',"Weight": ' + Weight +
        ',"PhysicalCondition": "' + PMCondition +
        '","TrainingPurpose": "' + Training +
        '","MemberPackage": ' + Package +
        ',"Payment": ' + Payment +
        ',"EmergencyContactNo": "' + EmergencyTP +
        '","RelationShip": "' + Relation +
        '","IntroducedBy": "' + Introduce +
        '","Active": ' + Active +
        ',"JoinDate": ' + JSON.stringify(Joindate) + '}';

    if (!$('#Fname').val() || !$('#Lname').val() || !$('#Nic').val() || !$('#DOB').val() || !$('#Age').val() || !$('#Height').val() || !$('#Weight').val() || !$('#Address').val() || !$('#PMCondition').val() || !$('#Training').val() || !$('#JoinDate').val()) {
        Swal.fire({
            icon: 'error',
            title: 'Oops...',
            text: 'Empty Value Can not be Allow!',
        });
    } else if (!Mailregex.test(Email.trim())) {
        Swal.fire({
            icon: 'error',
            title: 'Oops...',
            text: 'Please enter a vaild email address!',
        });
    } else if (!filter.test(ContactNo.trim()) || !filter.test(EmergencyTP.trim())) {
        Swal.fire({
            icon: 'error',
            title: 'Oops...',
            text: 'Please enter a vaild Phone No!',
        });
    } else if (Gender == 0 || Branch == 0 || Package == 0) {
        Swal.fire({
            icon: 'error',
            title: 'Oops...',
            text: 'Please Select a Value!',
        });
    } else {
        $("#waitform").css("display", "block");
        $("#btnAddMember").attr("disabled", true);
        if (Memberid == "0" || Memberid == "") {

            $.ajax({
                type: 'POST',
                url: $("#SaveMembers").val(),
                dataType: 'json',
                data: data,
                contentType: 'application/json; charset=utf-8',
                success: function (response) {
                    var myData = jQuery.parseJSON(JSON.stringify(response));
                    $("#waitform").css("display", "none");
                    $("#btnAddMember").attr("disabled", false);
                    if (myData.code == "1") {
                        Swal.fire({
                            position: 'center',
                            icon: 'success',
                            title: 'Your work has been saved',
                            showConfirmButton: false,
                            timer: 1500
                        });
                        $('#MemberModal').modal('toggle');
                        ListMemberDetails();
                        Clear();
                    } else if (myData.code == "0") {
                        Swal.fire({
                            icon: 'error',
                            title: 'Oops...',
                            text: 'Email Duplicated!',
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
        else {

            $.ajax({
                type: 'POST',
                url: $("#UpdateMemberShip").val(),
                dataType: 'json',
                data: data,
                contentType: 'application/json; charset=utf-8',
                success: function (response) {
                    var myData = jQuery.parseJSON(JSON.stringify(response));
                    $("#waitform").css("display", "none");
                    $("#btnAddMember").attr("disabled", false);
                    if (myData.code == "1") {
                        Swal.fire({
                            position: 'center',
                            icon: 'success',
                            title: 'Your work has been Updated',
                            showConfirmButton: false,
                            timer: 1500
                        });
                        $('#MemberModal').modal('toggle');
                        ListMemberDetails();
                        Clear();
                    } else {
                        Swal.fire({
                            icon: 'error',
                            title: 'Oops...',
                            text: 'Something went wrong!',
                        });
                        ListMemberDetails();
                        Clear();
                    }
                },
                error: function (jqXHR, exception) {
                }
            });

        }

    }
});

function ListMemberDetails() {
    $("#wait").css("display", "block");
    $.ajax({
        type: 'GET',
        url: $("#GetMemberDetails").val(),
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        success: function (response) {
            var myData = jQuery.parseJSON(JSON.stringify(response));
            $("#wait").css("display", "none");
            if (myData.code == "1") {
                var Result = myData.data;
                var tr = [];
                for (var i = 0; i < Result.length; i++) {
                    tr.push('<tr>');
                    tr.push("<td>" + Result[i].firstName + "</td>");
                    tr.push("<td>" + Result[i].lastName + "</td>");;
                    tr.push("<td>" + Result[i].contactNo + "</td>");;
                    tr.push("<td>" + Result[i].age + "</td>");;
                    tr.push("<td>" + Result[i].bmi + "</td>");;
                    tr.push("<td>" + Result[i].branch + "</td>");;
                    tr.push("<td><button onclick=\"EditMember('" + Result[i].memberId + "')\" class=\"btn btn-primary\"><i class=\"fa fa-edit\"></i> Edit </button></td>");
                    tr.push("<td><button onclick=\"DeleteMember('" + Result[i].memberId + "')\" class=\"btn btn-danger\"><i class=\"fa fa-trash\"></i> Delete </button></td>")

                    tr.push('</tr>');
                }

                $("#tbodyid").empty();
                $('.tblMember').append($(tr.join('')));
                $("#noRecords").css("display", "none");
                $("#tblMember").css("display", "table");
            } else if (myData.code == "0") {
                $("#noRecords").css("display", "block");
                $("#tblMember").css("display", "none");

                var tr = [];
                $("#tbodyid").empty();
                $('.tblMember').append($(tr.join('')));
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

function EditMember(Id) {
    $('#MemberModal').modal('show');
    LoadBranches();
    LoadGender();
    LoadMemberShipType();

    $.ajax({
        type: 'POST',
        url: $("#GetMemberShipById").val(),
        dataType: 'json',
        data: '{"MemberId": "' + Id + '"}',
        contentType: 'application/json; charset=utf-8',
        success: function (response) {
            var myData = jQuery.parseJSON(JSON.stringify(response));
            if (myData.code == "1") {
                var Result = myData.data;
                $("#MembershipId").val(Result['memberId']);
                $("#Fname").val(Result['firstName']);
                $("#Lname").val(Result['lastName']);
                $("#Gender").val(Result['gender']);
                $("#Nic").val(Result['nic']);
                $("#Branch").val(Result['branch']);
                $("#ContactNo").val(Result['contactNo']);
                $("#Email").val(Result['email']);
                $("#Age").val(Result['age']);
                $("#Height").val(Result['height']);
                $("#Weight").val(Result['weight']);
                $("#Address").val(Result['address']);
                $("#PMCondition").val(Result['physicalCondition']);
                $("#Training").val(Result['trainingPurpose']);
                $("#Package").val(Result['memberPackage']);
                $("#Introduce").val(Result['introducedBy']);
                $("#EmergencyTP").val(Result['emergencyContactNo']);
                $("#Relation").val(Result['relationShip']);
                $("#Payment").val(Result['payment']);
                $("#Status").prop("checked", Result.active)

                var DOB = new Date(Result.dateofBirth);
                DOB = String(DOB.getMonth() + 1).padStart(2, '0') + '/' + String(DOB.getDate()).padStart(2, '0') + '/' + DOB.getFullYear();
                $("#DOB").val(DOB);

                var Jdate = new Date(Result.joinDate);
                Jdate = String(Jdate.getMonth() + 1).padStart(2, '0') + '/' + String(Jdate.getDate()).padStart(2, '0') + '/' + Jdate.getFullYear();
                $("#JoinDate").val(Jdate);
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

function DeleteMember(Id) {

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
                url: $("#DeleteMemberShip").val(),
                dataType: 'json',
                data: '{"MemberId": "' + Id + '"}',
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
                        ListMemberDetails();
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
        url: $("#SearchMembers").val(),
        dataType: 'json',
        data: '{"FirstName": "' + FName + '","Branch": "' + Branch + '"}',
        contentType: 'application/json; charset=utf-8',
        success: function (response) {
            var myData = jQuery.parseJSON(JSON.stringify(response));
            $("#wait").css("display", "none");
            if (myData.code == "1") {
                var Result = myData.data;
                var tr = [];
                for (var i = 0; i < Result.length; i++) {
                    tr.push('<tr>');
                    tr.push("<td>" + Result[i].firstName + "</td>");
                    tr.push("<td>" + Result[i].lastName + "</td>");;
                    tr.push("<td>" + Result[i].contactNo + "</td>");;
                    tr.push("<td>" + Result[i].age + "</td>");;
                    tr.push("<td>" + Result[i].bmi + "</td>");;
                    tr.push("<td>" + Result[i].branch + "</td>");;
                    tr.push("<td><button onclick=\"EditMember('" + Result[i].memberId + "')\" class=\"btn btn-primary\"><i class=\"fa fa-edit\"></i> Edit </button></td>");
                    tr.push("<td><button onclick=\"DeleteMember('" + Result[i].memberId + "')\" class=\"btn btn-danger\"><i class=\"fa fa-trash\"></i> Delete </button></td>")

                    tr.push('</tr>');
                }

                $("#tbodyid").empty();
                $('.tblMember').append($(tr.join('')));
                $("#noRecords").css("display", "none");
                $("#tblMember").css("display", "table");
            } else if (myData.code == "0") {
                $("#noRecords").css("display", "block");
                $("#tblMember").css("display", "none");

                var tr = [];
                $("#tbodyid").empty();
                $('.tblMember').append($(tr.join('')));
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
    $('#MembershipId').val('');
    $('#Fname').val('');
    $('#Lname').val('');
    $('#Gender').val('');
    $('#Nic').val('');
    $('#Branch').val('');
    $('#ContactNo').val('');
    $('#DOB').val('');
    $('#Email').val('');
    $('#Age').val('');
    $('#Height').val('');
    $('#Weight').val('');
    $('#Address').val('');
    $('#PMCondition').val('');
    $('#Training').val('');
    $('#Package').val('');
    $('#Introduce').val('');
    $('#EmergencyTP').val('');
    $('#Relation').val('');
    $("#Payment").val('');
    $('#Status').prop('checked', true);
}

function Cancel() {
    $('#MemberModal').modal('toggle');
    //ListEmployeeDetails();
    Clear();
}