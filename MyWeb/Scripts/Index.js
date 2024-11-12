


$(document).ready(setAll);

function setAll() {
    $('#loading').show();

    // 监听按钮点击事件
    $('#left').on('click', leftArr);
    $('#right').on('click', rightArr);

    $.ajax({
        url: '/IndexHttp/IndexImg',
        type: 'GET',
        dataType: 'json',
        success: function (data) {

            // 显示数据
            $('#data').html(JSON.stringify(data));
        },
        error: function (xhr, status, error) {
            console.log(error);
        },
        complete: function () {
            // 加载完成后隐藏loading
            $('#loading').hide();
        }
    });
}

function rightArr() {
    // 右键按下逻辑
    console.log("右键按下");
}

function leftArr() {
    // 左键按下逻辑
    alert("左键按下");
}