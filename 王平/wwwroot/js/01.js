//创建一个函数getRandomArray(length, max) ，能返回一个长度不大于length，每个元素值不大于100随机整数数组。\ 

//(function () {
//    var num;
//    function getRandomArray(length,max) {
//        var arr = []; 
//        for (var i = 0; num <= max, i < length; i++) {
//            num = Math.ceil(Math.random() * 100);
//            arr.length = i;
//            arr.push(num);
//        } console.log(arr);
//    }
//    getRandomArray(5,10);
//})();


////使用setTimeout() （不是setInterval() ）实现每隔1秒钟依次显示：第n周，源栈同学random人。（n逐次递增，random随机） 

//(function () {
//    var max, count = document.getElementById("count"), countOne = document.getElementById("countOne"),
//        n = 1;
//    function fun() {
//        count.innerHTML = n++;
//        max = Math.ceil(Math.random() * 100);
//        countOne.innerHTML = max;
//        setTimeout(fun, 1000);
//    }
//    fun();
//})();





//完成猜数字的游戏：
//弹出游戏玩法说明，等待用户点击“确认”，开始游戏；
//浏览器生成一个不大于1000的随机正整数；
//用户输入猜测；
//如果用户没有猜对，浏览器比较后告知结果：“大了”或者“小了”。如果用户：
//只用了不到6次就猜到，弹出：碉堡了！
//只用了不到8次就猜到，弹出：666！
//用了8 - 10次猜到，弹出：猜到了。
//用了10次都还没猜对，弹出：^ (*￣(oo) ￣)^

//(function () {
//    alert("游戏介绍");
//    var num = Math.floor(Math.random() * 20 + 1);
//    for (var i = 0; i <= 10; i++) {
//        var n = prompt(
//        parseInt(n);
//        if (isNaN(n)) {
//            alert("非法字符");
//        } else if (n == num) {
//            if (i < 6) {
//                alert("碉堡了！");
//                break;
//            } else if (i < 8) {
//                alert("666！");
//                break;
//            } else
//                alert("^ (*￣(oo) ￣)^");
//            break;
//        } else if (n > num) {
//            alert("大了");
//        } else if (n < num) {
//            alert("小了");
//        }
//    }
//})();
////用class声明一个课程（Course），包含属性：name，startDate，endDate，students，以及方法：begin()和end() 
////生成两个课程对象：JavaScript和SQL 
////调用对象的begin()和end()方法，可以在控制台输出开课信息，如：JavaScript于2019年5月5日开课，共有5名同学（两开花、王枫、王平、采铃、老程）报名。
////不修改class，动态的改变begin()方法，使其能影响所有Course对象 
////让end()方法为各自对象“自有”，其他对象无法修改
////在Course中使用getter和setter包装endDate，保证endDate不会小于startDate，也不会比startDate多出365天 
const Student = class Course {
    constructor(name, startDate, students) {
        this.name = name;
        this.startDate = startDate;
        this.endDate;
        this.students = students;
        ////让end()方法为各自对象“自有”，其他对象无法修改 
        this.end = function () {
            var END = this.endDate,
                value = ("结束时间：" + this.endDate);
            return value
        }
    }

    //    ////在Course中使用getter和setter包装endDate，保证endDate不会小于startDate，也不会比startDate多出365天 
    set EndDate(value) {
        var tim = Date.parse(value) - Date.parse(this.startDate),
            star = 365 * 24 * 60 * 60 * 1000;

        if (tim < 0) {
            alert("结束时间小于开始时间");

        } else if (tim > star) {
            alert("课程时间超过365天");

        } else {
            this.endDate = value
        }
    }
    get EndDate() {
        return this.endDate
    }



    begin() {
        console.log(this.name + "于" + this.startDate + "开课，共有" + this.students + "等5名同学报名。" + this.end());
    }
};
////当new了一个class之后，class里声明的方法就会被copy到新生成的实例对象上
let js = new Student("JavaScript", "2019/5/5", ["两开花", "王枫", "王平", "采铃", "老程"]),
    SQL = new Student("SQL", "2019/5/5", ["两开花", "王枫", "王平", "采铃", "老程"]);
js.EndDate = "2019/5/6";
SQL.EndDate = "2019/5/6";
js.begin();
SQL.begin();
//////不修改class，动态的改变begin()方法，使其能影响所有Course对象
Student.prototype.begin = function () {
    alert(this.name + "于" + this.startdate + "开课，共有" + this.students + "等5名同学报名。");
}
js.begin();

////判断并证明以下说法：
////ES里的class其实就是一个function
console.log(typeof Student);
////constructor总是返回class的实例

////JavaScript里面，类就是对象，对象也是类
console.log("类就是对象，对象也是类:"+js.begin===SQL.begin)
////只有Function才有prototype
console.log("Student:"+Student.prototype.begin())
console.log("js:"+typeof js);
console.log(js.prototype.begin())
////Javascript是动态类型语言，所以对象的类型是可以随意更改的


