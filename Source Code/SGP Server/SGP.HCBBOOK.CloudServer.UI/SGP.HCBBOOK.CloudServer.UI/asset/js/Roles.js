$(document).ready(function () {
    $('a.btn.btn-link.waves-effect').click(function () {
        var rolename = $('input.form-control.addrole').val();
        var indexDisplay = $('input.form-control.indexDisplay').val();
        $.ajax({
            url: "/Rolesmanage/CreateRole",
            type: "post",
            data: {
                'rolename': rolename,
                'display': indexDisplay
            },
            success: function (response) {
                alert(response);
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus, errorThrown);
            }
        });
    });

    $('a.SetUserRole').click(function () {
        $.ajax({
            url: "/UserManage/GetAllStaff",
            type: "post",
            data: {
                
            },
            success: function (res) {
                $('div.modal-body.user').html(res);
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus, errorThrown);
            }
        });
    });
    
    //$(document).delegate('click', 'a.loadCompany', function () {
    //    $.ajax({
    //        url: "/CustomerCompany/GetListCompany",
    //        type: "post",
    //        data: {

    //        },
    //        success: function (res) {
    //            $('div.modal-body.listCompany').html(res);
    //        },
    //        error: function (jqXHR, textStatus, errorThrown) {
    //            console.log(textStatus, errorThrown);
    //        }
    //    });
    //});
});