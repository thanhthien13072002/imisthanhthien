const usernameEle = document.getElementById('username');
const usernametk = document.getElementById('usernametk');
const usernamemk = document.getElementById('usernamemk');
const usernameremk = document.getElementById('usernameremk');
const emailEle = document.getElementById('email');
const phoneEle = document.getElementById('phone');
const btnRegister = document.getElementById('btn-register');
const inputEles = document.querySelectorAll('.input-row');




btnRegister.addEventListener('click', function () {
    Array.from(inputEles).map((ele) =>
        ele.classList.remove('success', 'error')
    );
    let isValid = checkValidate();

    if (isValid) {
        alert('Gửi đăng ký thành công');
    }
});

function checkValidate() {
    //dang ky
    let usernameValue = usernameEle.value;

    let usernameValuetk = usernametk.value;

    let usernameValuemk = usernamemk.value;

    let usernameValueremk = usernameremk.value;

    let emailValue = emailEle.value;

    let phoneValue = phoneEle.value;

    if (usernameValue == '') {
        setError(usernameEle, 'Tên không được để trống');
        isCheck = false;
    } else {

        setSuccess(usernameEle);
    }

    if (usernameValuetk == '') {
        setError(usernametk, 'Tên đăng nhập không được để trống');
        isCheck = false;
    } else {
        setSuccess(usernametk);
    }

    if (usernameValuemk == '') {
        setError(usernamemk, 'Mật khẩu không được để trống');
        isCheck = false;
    } else {
        setSuccess(usernamemk);
    }

    if (usernameValueremk == '') {
        setError(usernameremk, 'Mật khẩu không được để trống');
        isCheck = false;
    }

    else if (usernameValueremk != usernameValuemk)
    {
        setError(usernameremk, 'Mật khẩu nhập không khớp');
        isCheck = false;
    }

    else {
        setSuccess(usernameremk);
    }

    if (emailValue == '') {
        setError(emailEle, 'Email không được để trống');
        isCheck = false;

    } else if (!isEmail(emailValue)) {
        setError(emailEle, 'Email không đúng định dạng');
        isCheck = false;
    } else {
        setSuccess(emailEle);
    }

    if (phoneValue == '') {
        setError(phoneEle, 'Số điện thoại không được để trống');
        isCheck = false;

    } else if (!isPhone(phoneValue)) {
        setError(phoneEle, 'Số điện thoại không đúng định dạng');
        isCheck = false;

    } else {
        setSuccess(phoneEle);
    }

    return isCheck;
}

function setSuccess(ele) {
    ele.parentNode.classList.add('success');
}

function setError(ele, message) {
    let parentEle = ele.parentNode;
    parentEle.classList.add('error');
    parentEle.querySelector('small').innerText = message;
}

function isEmail(email) {
    return /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/.test(
        email
    );
}

function isPhone(number) {
    return /(84|0[3|5|7|8|9])+([0-9]{8})\b/.test(number);
}