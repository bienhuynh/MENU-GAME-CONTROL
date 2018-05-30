$(function () {
    $('.dd').nestable();

    $('.dd').on('change', function () {
        var $this = $(this);
        var serializedData = window.JSON.stringify($($this).nestable('serialize'));

        var jsonAvailbaleOutput = $('textarea.form-control.no-resize.available').val();
        $.ajax({
            url: "/RolesManage/ChangeParent",
            type: "post",
            data: {
                'jsonOutput': serializedData
            },
            success: function (response) {
                //if (response != null)
                //    alert(response);
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus, errorThrown);
            }
        });

        $this.parents('div.body').find('textarea').val(serializedData);
        var jsonRemoveOutput = $('textarea.form-control.no-resize.remove').val();
        $.ajax({
            url: "/RolesManage/DeleteRole",
            type: "post",
            data: {
                'jsonOutput': jsonRemoveOutput
            },
            success: function (response) {
                //if (response != null)
                //    alert(response);
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus, errorThrown);
            }
        });
        /*
         Add role for staff of a company
         */
        var userrole = $('textarea.form-control.no-resize.jsonOutput').val();
        var customerCode = $('input.form-control.no-resize.customerCode').val();
        var username = $('input.form-control.no-resize.username').val();
        $.ajax({
            url: "/RolesManage/SetRoleForUser",
            type: "post",
            data: {
                'jsonOutput': userrole,
                'customerCode': customerCode,
                'username': username
            },
            success: function (response) {
                //if (response != null)
                //    alert(response);
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus, errorThrown);
            }
        });
    });
});