//    ////全选
//    var and = document.getElementById("and").getElementsByTagName("input");
//        and[3].onclick = function () {
//            for (var i = 0; i < and.length; i++) {
//        and[i].checked = and[3].checked;
//    }
//}
//   
//        ////参考求助首页侧边栏关键字，实现：当鼠标移动到关键字上，显示关键字被使用次数
//        function keywords() {
//                   var i = document.getElementsByTagName("a");
//                   for (var j = 0; j < i.length; j++) {
//            i[j].onmouseover = function () {
//                console.log(Math.ceil(Math.random() * 100))
//            };
//        }
//        };
//        keywords();
////// 参考文章的全系列阅读功能，当滚动到页面底部时，将页面现有内容粘贴到页面底部，直到5次过后，在页面底部显示：已经没有更多内容了
// //var circulate = document.body,
// //    i = 0;

//            //document.body.onscroll = function () {
//            //    var cle = circulate.cloneNode(true);
//            //    var ScrollTop = document.documentElement.scrollTop,
//            //        offsetHeight = document.documentElement.offsetHeight,
//            //        clientHeight = document.documentElement.clientHeight;
//            //    if (ScrollTop+ clientHeight === offsetHeight && i < 5) {
//            //        document.getElementsByTagName("html")[0].appendChild(cle)
//            //        i++;
//            //    }
//            //    else if (ScrollTop + clientHeight === offsetHeight && i === 5) {
//            //        alert("到底了");
//            //    }
//            //}
