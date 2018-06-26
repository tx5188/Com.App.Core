$(function () {
    $("#navbar-nav").html("");
   
    //加载主菜单
    $.ajax({
        type: 'Get',
        url: '/home/loadSysMenu', //url  action是方法的名称
        data: {
            parentId: "0" 
        },
        dataType: "json", //可以是text，如果用text，返回的结果为字符串；如果需要json格式的，可是设置为json
        ContentType: "application/json; charset=utf-8",
        async: true,
        success: function (data) {
          //  var data = JSON.parse(data);
            var htmlText = '';
            for (var i in data) {
                htmlText += ' <li aria-haspopup="true" class="menu-dropdown classic-menu-dropdown" id="' + data[i].Id + '">';
                if (data[i].Url == null || data[i].Url == "") {
                    htmlText += '<a href=#>' +
                        '<i style="font-size: 18px" class="icon-' + data[i].Img + '"></i>' +
                        '&nbsp;&nbsp;' + data[i].MenuName + '' +
                        '<span class="arrow"></span>' +
                        '</a>' +
                        '<ul class="dropdown-menu pull-left" id="ul_' + data[i].Id + '">' +
                        '</ul>' +
                        '</li>';
                }
                else {
                    htmlText += '<a href="' + data[i].Url + '">' +
                        '<i style="font-size: 18px" class="icon-' + data[i].Img + '"></i>' +
                        '&nbsp;&nbsp;' + data[i].MenuName + '' +
                        '<span class="arrow"></span>' +
                        '</a>' +
                        '<ul class="dropdown-menu pull-left" id="ul_' + data[i].Id + '">' +
                        '</ul>' +
                        '</li>';
                }
             
            }
            $("#navbar-nav").append(htmlText);
           /* $.ajax({
                url: "/menu/getMenuSession",
                type: "post",
                dataType: "text",
                success: function (data) {
                    $("#navbar-nav>li").eq(data).attr("class", "menu-dropdown classic-menu-dropdown active")
                }
            })
            $("#navbar-nav>li").click(function () {
                var index = $(this).index()
                $.ajax({
                    url: "/menu/saveMenuSession",
                    type: "post",
                    data: {
                        index: index
                    },
                    dataType: "text",
                    success: function () { }
                })
            })*/
            //给主菜单添加hover事件
            setHover();
        }
    });
});

//菜单hover事件
function setHover() {
    //加载次级菜单
    $("#navbar-nav>li").hover(function () {
        var parentId = $(this).attr("id")
        $("#ul_" + parentId).empty();
        var htmlText = '';
        $.ajax({
            type: 'get',
            url: '/home/loadSysMenu', //url  action是方法的名称
            data: {
                parentId: parentId,
            },
            dataType: "json", //可以是text，如果用text，返回的结果为字符串；如果需要json格式的，可是设置为json
            ContentType: "application/json; charset=utf-8",
            async: true,
            success: function (data) {
                $("#ul_" + parentId).empty();
                for (var i in data) {
                    htmlText += '<li aria-haspopup="true" id="' + data[i].Id+ '">' +
                        '<a href="' + data[i].Url + '" target="_self" class="nav-link">' +
                        '' + data[i].MenuName + '</a></li>';
                }
                $("#ul_" + parentId).append(htmlText);
            }
        });
    })
}