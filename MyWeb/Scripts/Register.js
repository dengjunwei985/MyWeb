import { validatePassword } from "./Scripts/Login.js";



function register() {
    var username = document.getElementById("username").value;
    var password = document.getElementById("password").value;
    var confirmPassword = document.getElementById("confirmPassword").value;
    var email = document.getElementById("email").value;

    if (username == "" || password == "" || confirmPassword == "" || email == "") {
        alert("请填空白项");
        return false;
    }

    if (password != confirmPassword) {
        alert("两次输入的密码不一致");
        return false;
    }

    if (!validatePassword(password)) {
       return false;
    }

    return true;
}