

//$(function () {
//    $("#searchInput").autocomplete({
//        source: function (request, response) {
//            $.ajax({
//                url: "/AdminPanel/GetUsers/",
//                data: { "searchUser": request.term },
//                type: "POST",
//                success: function (data) {
//                    response($.map(data, function (item) {
//                        return item;
//                    }))
//                },
//                error: function (response) {
//                    alert(response.responseText);
//                },

//            });
//        },
//        select: function (e, i) {
//            $("#UserId").val(i.item.val);
//        },
//        minLenght: 2
//    });
//});





//$(document).ready(function (e) {

//    $("#SelectClient").click(function (e) {

//        e.preventDefault();


//        $.ajax({
//            url: "/AdminPanel/SelectUser/",
//            data: { searchUser: $("#searchInput").val() },
//            cache: false,
//            success: function (returnhtml) {
//                var obj = JSON.parse(returnhtml);
//                $("#NumId").html(obj.Email);
//                $("#EmailId").html(obj.Email);
//                $("#PhoneId").html(obj.PhoneNumber);
//                $("#NameId").html(obj.UserFIO);
//                $("#searchInput").val("");
//            },
//            dataType: "json"
//        });

//    });

//});


//$().ready(function () {
//    $("#searchInput").autocomplete({
        
//        source: function (request, response) {
//            $.ajax({
//                url: "/AdminPanel/GetUsers/",
//                data: { "searchUser": request.term },
//                type: "POST",
//                success: function (data) {
//                    response($.map(data, function (item) {
//                        return item;
//                    }))
//                }

//            });
//        }
//    });
//});

$().ready(function (e) {

    $("#seaBtn").click(function (e) {

        e.preventDefault();


        $.ajax({
            type: "GET",
            url: "/AdminPanel/Search/",
            data: { searchline: $("#seaInput").val() },
            datatype: "html",
            cache: false,
            success: function (data) {
                $("#s-list").empty();
                $("#s-list").html(data);
            },

        });

    });

});



//$(document).ready(function (e) {

//    $("#btnToBuy").click(function (e) {

//        e.preventDefault();


//        $.ajax({
//            url: "/AdminPanel/ToCart/",
//            data: { partId: $("#partId").val() },
//            cache: false,
//            success: function (returnhtml) {
//                var obj = JSON.parse(returnhtml);
//                $("#NumId").html(obj[0].Email);
//                $("#EmailId").html(obj[0].Email);
//                $("#PhoneId").html(obj[0].PhoneNumber);
//                $("#NameId").html(obj[0].UserFIO);
//                $("#cart-total").html("(" + obj[1].CartItems + ")");
//                $("#searchInput").val("");

//            },
//            dataType: "json"
//        });

//    });

//});

//$(document).ready(function (e) {

//    $("#btnToBuy").click(function (e) {

//        e.preventDefault();


//        $.ajax({
//            type: "POST",
//            url: "/AdminPanel/ToCart/",
//            data: { quant: $("#quant").val() },
//            cache: false,
//            dataType: "json",
//            success: function (data) {

//                alert("Good"); 
//            },

//        });
//        return false;
//    });

//});


//$("#s-list").ready(function () {

//    $("form").submit(function (e) {

//        var sendingData = {
//            partId: $('input[name="partId"]').val(),
//            quant: $('input[name="quant"]').val()
//        }

//        e.preventDefault();
//        $.ajax({

//            url: "/AdminPanel/ToCartTest/",
//            contentType: 'application/json',
//            dataType: "json",
//            method: "POST",
//            //data: JSON.stringify({ partId: this.elements["partId"].value }),

//            success: function (data) {
//                alert("Value Added");

//            },
//            data: JSON.stringify(sendingData)

//        });

//    });
//});

//$().ready(function () {

//    var buttons = $(".cart-button");

//    for (index = 0; index < buttons.length; index++) {
//        button = buttons[index];
//        $(button).click(function (e) {
//        //$.post('@Url.Action("PostActionToUpdatePoints", "Home")').always(function () {
//        //    $('.traget').Load('/Home/UpdatePoints');
//        alert("Работает");
//        })

//    }




//});

    //$("#SelectClient").click(function (e) {
    //    //$.post('@Url.Action("PostActionToUpdatePoints", "Home")').always(function () {
    //    //    $('.traget').Load('/Home/UpdatePoints');
    //    alert("Работает");
    //})





