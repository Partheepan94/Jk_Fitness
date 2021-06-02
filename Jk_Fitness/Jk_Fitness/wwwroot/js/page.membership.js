$(document).ready(function () {
    ListMemberDetails();
    LoadBranchesforSearch();
    LoadMemberShipType();
    var BranchArray;
    var MemberShipPackageArray;
    var EmployeeDetailsArray;
});

$('#btnAdd').click(function () {
    $('.modal').removeClass('freeze');
    $('.modal-content').removeClass('freeze');
    $('#MemberModal').modal('show');
    LoadBranches();
    LoadMemberShipPackage();

    var CurDate = new Date();
    CurDate = String(CurDate.getMonth() + 1).padStart(2, '0') + '/' + String(CurDate.getDate()).padStart(2, '0') + '/' + CurDate.getFullYear();
    $("#DOB").val(CurDate);
    $("#JoinDate").val(CurDate);
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
    Branch.append($("<option/>").val(0).text("-Select Branch-"));
    $.each(BranchArray, function () {
        Branch.append($("<option/>").val(this.branchName).text(this.branchName));
    });
}

function LoadMemberShipType() {
    
    MemberShipPackage = [];
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
                MemberShipPackageArray = myData.data;
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
    var PackageAmount = $.grep(MemberShipPackageArray, function (v) {
        return v.id == Id;
    })
    
    $("#Payment").val(PackageAmount[0].membershipAmount.toFixed(2));
}

function LoadMemberShipPackage() {
    $('#Package').find('option').remove().end();
    Package = $('#Package');

    Package.append($("<option/>").val(0).text("-Select Season Type-"))
    $.each(MemberShipPackageArray, function () {
        Package.append($("<option/>").val(this.id).text(this.membershipName));
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
    var BMI = $('#BMI').val();
    var HouseNo = $('#HouseNo').val();
    var Street = $('#Street').val();
    var District = $('#District').val();
    var Province = $('#Province').val();
    var Package = $('#Package').val();
    var Joindate = new Date($('#JoinDate').val());
    var Payment = $('#Payment').val();
    var Introduce = $('#Introduce').val();
    var EmergencyTP = $('#EmergencyTP').val();
    var Relation = $('#Relation').val();
    var Smoking = $('#Smoking').prop('checked') ? "true" : "false";
    var Discomfort = $('#Discomfort').prop('checked') ? "true" : "false";
    var Herina = $('#Herina').prop('checked') ? "true" : "false";
    var Diabets = $('#Diabets').prop('checked') ? "true" : "false";
    var Pain = $('#Pain').prop('checked') ? "true" : "false";
    var Complaint = $('#Complaint').prop('checked') ? "true" : "false";
    var Trace = $('#Trace').prop('checked') ? "true" : "false";
    var Doctors = $('#Doctors').prop('checked') ? "true" : "false";
    var Cholesterol = $('#Cholesterol').prop('checked') ? "true" : "false";
    var Pregnant = $('#Pregnant').prop('checked') ? "true" : "false";
    var Aliments = $('#Aliments').prop('checked') ? "true" : "false";
    var Surgery = $('#Surgery').prop('checked') ? "true" : "false";
    var Pressure = $('#Pressure').prop('checked') ? "true" : "false";
    var Incorrigible = $('#Incorrigible').prop('checked') ? "true" : "false";
    var Musele = $('#Musele').prop('checked') ? "true" : "false";
    var Fat = $('#Fat').prop('checked') ? "true" : "false";
    var Body = $('#Body').prop('checked') ? "true" : "false";
    var Fitness = $('#Fitness').prop('checked') ? "true" : "false";
    var Athletics = $('#Athletics').prop('checked') ? "true" : "false";
    var Active = $('#Status').prop('checked') ? "true" : "false";

    var Mailregex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;

    var data = '{"MemberId": ' + Memberid +
        ' ,"FirstName": "' + FirstName +
        ' " ,"LastName":" ' + latName +
        ' " ,"Gender":" ' + Gender +
        ' ","NIC":" ' + Nic +
        ' " ,"HouseNo":" ' + HouseNo +
        ' ","Street":" ' + Street +
        ' ","District":" ' + District +
        ' ","Province":" ' + Province +
        ' ","ContactNo":" ' + ContactNo +
        ' ","DateofBirth": ' + JSON.stringify(DOB) +
        ' ,"Email":" ' + Email +
        ' ","Branch":" ' + Branch +
        ' ","Age": ' + Age +
        ',"Height": ' + Height +
        ',"Weight": ' + Weight +
        ',"BMI": ' + BMI +
        ',"MemberPackage": ' + Package +
        ',"Payment": ' + Payment +
        ',"EmergencyContactNo": "' + EmergencyTP +
        '","RelationShip": "' + Relation +
        '","IntroducedBy": "' + Introduce +
        '","Active": ' + Active +
        ',"JoinDate": ' + JSON.stringify(Joindate) +
        ',"Smoking": ' + Smoking +
        ',"Discomfort": ' + Discomfort +
        ',"Cholesterol": ' + Cholesterol +
        ',"Herina": ' + Herina +
        ',"Diabets": ' + Diabets +
        ',"Pain": ' + Pain +
        ',"Complaint": ' + Complaint +
        ',"Incorrigible": ' + Incorrigible +
        ',"Doctors": ' + Doctors +
        ',"Aliments": ' + Aliments +
        ',"Surgery": ' + Surgery +
        ',"Pressure": ' + Pressure +
        ',"Trace": ' + Trace +
        ',"Pregnant": ' + Pregnant +
        ',"Musele": ' + Musele +
        ',"Fat": ' + Fat +
        ',"Body": ' + Body +
        ',"Fitness": ' + Fitness +
        ',"Athletics": ' + Athletics + '}';

    if (!$('#Fname').val() || !$('#Lname').val() || !$('#Nic').val() || !$('#DOB').val() || !$('#ContactNo').val() || !$('#Height').val() || !$('#Weight').val() || !$('#District').val() || !$('#Province').val() ||  !$('#JoinDate').val()) {
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
    } else if (Gender == 0 || Branch == 0 || Package == 0) {
        Swal.fire({
            icon: 'error',
            title: 'Oops...',
            text: 'Please Select a Value!',
        });
    } else {
        $("#waitform").css("display", "block");
        $('.modal').addClass('freeze');
        $('.modal-content').addClass('freeze');
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
                EmployeeDetailsArray = Result;
                var tr = [];
                for (var i = 0; i < Result.length; i++) {
                    tr.push('<tr>');
                    tr.push("<td>" + Result[i].memberId + "</td>");;
                    tr.push("<td>" + Result[i].firstName + "</td>");
                    tr.push("<td>" + Result[i].lastName + "</td>");;
                    tr.push("<td>" + Result[i].nic + "</td>");;
                    tr.push("<td>" + Result[i].branch + "</td>");;
                    
                    if (Result[i].active == true)
                        tr.push("<td><strong style=\"color:green\">Active</strong></td>");
                    else
                        tr.push("<td><strong style=\"color:red\">Deactive</strong></td>"); 
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
    $('.modal').removeClass('freeze');
    $('.modal-content').removeClass('freeze');
    $("#wait").css("display", "block");
    
    LoadBranches();
    LoadMemberShipPackage();

    var MemberDetail = $.grep(EmployeeDetailsArray, function (v) {
        return v.memberId == Id;
    })

    if (MemberDetail.length != 0) {
        var Result = MemberDetail[0];

        if (Result.gender == "Female") {
            $("#Frule").css("display", "flex");
        }
        else {
            $("#Frule").css("display", "none");
        }

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
        $("#BMI").val(Result['bmi']);
        $("#HouseNo").val(Result['houseNo']);
        $("#Street").val(Result['street']);
        $("#District").val(Result['district']);
        $("#Province").val(Result['province']);
        $("#Payment").val(Result['payment']);
        $("#Package").val(Result['memberPackage']);
        $("#Introduce").val(Result['introducedBy']);
        $("#EmergencyTP").val(Result['emergencyContactNo']);
        $("#Relation").val(Result['relationShip']);
        $("#Smoking").prop("checked", Result.smoking)
        $("#Discomfort").prop("checked", Result.discomfort)
        $("#Herina").prop("checked", Result.herina)
        $("#Diabets").prop("checked", Result.diabets)
        $("#Pain").prop("checked", Result.pain)
        $("#Complaint").prop("checked", Result.complaint)
        $("#Trace").prop("checked", Result.trace)
        $("#Doctors").prop("checked", Result.doctors)
        $("#Cholesterol").prop("checked", Result.cholesterol)
        $("#Pregnant").prop("checked", Result.pregnant)
        $("#Aliments").prop("checked", Result.aliments)
        $("#Surgery").prop("checked", Result.surgery)
        $("#Pressure").prop("checked", Result.pressure)
        $("#Incorrigible").prop("checked", Result.incorrigible)
        $("#Musele").prop("checked", Result.musele)
        $("#Fat").prop("checked", Result.fat)
        $("#Body").prop("checked", Result.body)
        $("#Fitness").prop("checked", Result.fitness)
        $("#Athletics").prop("checked", Result.athletics)
        $("#Status").prop("checked", Result.active)

        var DOB = new Date(Result.dateofBirth);
        DOB = String(DOB.getMonth() + 1).padStart(2, '0') + '/' + String(DOB.getDate()).padStart(2, '0') + '/' + DOB.getFullYear();
        $("#DOB").val(DOB);

        var Jdate = new Date(Result.joinDate);
        Jdate = String(Jdate.getMonth() + 1).padStart(2, '0') + '/' + String(Jdate.getDate()).padStart(2, '0') + '/' + Jdate.getFullYear();
        $("#JoinDate").val(Jdate);

        ShowIdealweight();
        $("#wait").css("display", "none");
        $('#MemberModal').modal('show');
    } else {
        Swal.fire({
            icon: 'error',
            title: 'Oops...',
            text: 'Something went wrong!',
        });
    }
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
    BranchArray = [];
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
                BranchArray = Result;
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

    var Result = $.grep(EmployeeDetailsArray, function (v) {
        return (v.branch == Branch && v.firstName.indexOf(FName)!=-1);
    })

    $("#wait").css("display", "none");
    if (Result.length !=0) {
       
        var tr = [];
        for (var i = 0; i < Result.length; i++) {
            tr.push('<tr>');
            tr.push("<td>" + Result[i].memberId + "</td>");;
            tr.push("<td>" + Result[i].firstName + "</td>");
            tr.push("<td>" + Result[i].lastName + "</td>");;
            tr.push("<td>" + Result[i].payment + "</td>");;

            if (Result[i].active == true)
                tr.push("<td><strong style=\"color:green\">Active</strong></td>");
            else
                tr.push("<td><strong style=\"color:red\">Deactive</strong></td>");
            tr.push("<td><button onclick=\"EditMember('" + Result[i].memberId + "')\" class=\"btn btn-primary\"><i class=\"fa fa-edit\"></i> Edit </button></td>");
            tr.push("<td><button onclick=\"DeleteMember('" + Result[i].memberId + "')\" class=\"btn btn-danger\"><i class=\"fa fa-trash\"></i> Delete </button></td>")

            tr.push('</tr>');
        }

        $("#tbodyid").empty();
        $('.tblMember').append($(tr.join('')));
        $("#noRecords").css("display", "none");
        $("#tblMember").css("display", "table");
    } else {
        $("#noRecords").css("display", "block");
        $("#tblMember").css("display", "none");

        var tr = [];
        $("#tbodyid").empty();
        $('.tblMember').append($(tr.join('')));
    }

});

function Clear() {
    $('#MembershipId').val(0);
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
    $("#BMI").val('');
    $("#ExWeight").val('');
    $("#HouseNo").val('');
    $("#Street").val('');
    $("#District").val('');
    $("#Province").val('');
    $('#Package').val('');
    $('#Introduce').val('');
    $('#EmergencyTP').val('');
    $('#Relation').val('');
    $("#Payment").val('');
    $('#Status').prop('checked', true);
    $("#Smoking").prop("checked", false)
    $("#Discomfort").prop("checked", false)
    $("#Herina").prop("checked", false)
    $("#Diabets").prop("checked", false)
    $("#Pain").prop("checked", false)
    $("#Complaint").prop("checked", false)
    $("#Trace").prop("checked", false)
    $("#Doctors").prop("checked", false)
    $("#Cholesterol").prop("checked", false)
    $("#Pregnant").prop("checked", false)
    $("#Aliments").prop("checked", false)
    $("#Surgery").prop("checked", false)
    $("#Pressure").prop("checked", false)
    $("#Incorrigible").prop("checked", false)
    $("#Musele").prop("checked", false)
    $("#Fat").prop("checked", false)
    $("#Body").prop("checked", false)
    $("#Fitness").prop("checked", false)
    $("#Athletics").prop("checked", false)
    $("#Under").css("display", "none");
    $("#Normal").css("display", "none");
    $("#Over").css("display", "none");
    $("#Obese").css("display", "none");
}

function Cancel() {
    $('#MemberModal').modal('toggle');
    ListMemberDetails();
    Clear();
}

function ShowIdealweight() {
    var Height = $('#Height').val();
    var Weight = $('#Weight').val();
    var Bmi = Weight / Math.pow((Height / 100), 2);
    if (Bmi < 18.5) {
        $("#Under").css("display", "flex");
        $("#Normal").css("display", "none");
        $("#Over").css("display", "none");
        $("#Obese").css("display", "none");
    }
    else if (Bmi >= 18.5 && Bmi <= 25) {
        $("#Under").css("display", "none");
        $("#Normal").css("display", "flex");
        $("#Over").css("display", "none");
        $("#Obese").css("display", "none");
    }
    else if (Bmi >= 26 && Bmi <= 30) {
        $("#Under").css("display", "none");
        $("#Normal").css("display", "none");
        $("#Over").css("display", "flex");
        $("#Obese").css("display", "none");
    }
    else {
        $("#Under").css("display", "none");
        $("#Normal").css("display", "none");
        $("#Over").css("display", "none");
        $("#Obese").css("display", "flex");
    }

    var exWeight = (Math.pow((Height / 100), 2) * 18.5).toFixed(2) + " Kg" + " - " + (Math.pow((Height / 100), 2) * 25).toFixed(2) + " Kg";
    $('#ExWeight').val(exWeight);
}