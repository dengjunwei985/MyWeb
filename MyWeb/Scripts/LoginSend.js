var appState = window.appState || {};

$(document).ready(getInit);

function getInit() {
    // 初始化操作

}

function validatePassword() {
    // 获取输入的密码
    var password = document.getElementById('user_password').value;

    // 定义正则表达式
    var lengthRegex = /^.{6,15}$/; // 长度在6到15之间
    var letterRegex = /[a-zA-Z]/; // 至少包含一个字母
    var numberRegex = /[0-9]/; // 至少包含一个数字

    // 检查密码是否符合所有条件
    if (!lengthRegex.test(password)) {
        alert('密码长度必须在6到15个字符之间');
        return false;
    }

    if (!letterRegex.test(password)) {
        alert('密码必须包含至少一个字母');
        return false;
    }

    if (!numberRegex.test(password)) {
        alert('密码必须包含至少一个数字');
        return false;
    }

    // 如果所有条件都满足，显示成功消息
    alert('密码有效');
    // 这里可以继续处理登录逻辑
}

function loginSend(event) {
    // 获取输入框的值
    event.preventDefault(); 
    var email = document.getElementById('user_email').value;
    var password = document.getElementById('user_password').value;


    console.log('邮箱: ' + email);
    console.log('密码: ' + password);

    if (validatePassword() == false) {
        return false;
    } else {
        $.ajax({
            url: '/Login/LoginGet',
            type: 'POST',
            data: { user_email: email, user_password: password },
            success: function (data) {
                console.log(data);
            },
            error: function (xhr, status, error) {
                console.log(xhr.responseText);
                alert('登录失败！');
            }
        });
    }
}


export { validatePassword, loginSend }