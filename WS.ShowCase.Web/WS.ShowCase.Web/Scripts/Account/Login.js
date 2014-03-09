function showLogin()
{
    $('#loginModal').modal('show')
}

function PerformLogin()
{
    $.post("Account/Login", $("#frmLogin").serialize(),
    function (result) {
        if (result != '') {
            ShowMessageDialog('Alert', result);
        }
        else {
            location.reload();
        }
    });  
}