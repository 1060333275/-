using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Xml.Linq;

namespace _0._0
{
    class Program
    {

        static void Main(string[] args)
        {
            // Random s = new Random();
            // Random n = new Random();
            // int tall = 100;
            // int wide = 200;
            ////生成一个宽（wide）长（tall）的画布
            // Bitmap img = new Bitmap(wide, tall);
            // Graphics g = Graphics.FromImage(img);
            // g.Clear(Color.Yellow);
            // string str = GetRandomString(4, true, true, true, "");
            // g.DrawString(str, new Font("黑体", 50), new SolidBrush(Color.Red), new PointF(wide/8, tall/6));
            // //随机生成不大于（tall*10）个位置不确定的像素点
            // for (int i = 0; i < tall*10; i++)
            // {
            //     img.SetPixel(n.Next(wide), n.Next(tall), Color.Black);
            // }
            // //随机生成不大于（tall/10）条的长度和位置不确定的直线
            // for (int i = 0; i < tall/10; i++)
            // {
            //     g.DrawLine(new Pen(Color.Black), s.Next(wide), s.Next(tall), n.Next(wide), n.Next(tall));
            // }
            // img.Save(@"d:\vs\验证码.jpg", ImageFormat.Jpeg);


            XElement luckystack = new XElement(
                   "articles",
            new XComment("以下存放所有“源栈”所有文章"),        //注释
            new XElement("article",
                new XElement("id", "1"),
                    new XElement("title", "源栈培训：C#进阶-7：Linq to XML"),
                    new XElement("bpdy", "什么是XML（EXtensible Markup Language）是一种文本" +
                    "文件格式被设计用来传输和存储数据由：标签和属性组成元素（节点），由元素组成" +
                    "“树状结构”必须有而且只能有一个根节点其他："),
                    new XAttribute("isDraft", false),
                new XElement("authorId", "1"),
                new XElement("publishDate", "2019/6/18 18:15"),
                 new XElement("comments",
                 new XElement("comment",
                 new XElement("id", "12"),
                  new XElement("body", "不错，赞！"),
                   new XElement("authorId", "2"),
                 new XAttribute("recommend", true)),
                 new XElement("comment",
                 new XElement("id", "14"),
                   new XElement("body", "作业太难了"),
                    new XElement("authorId", "3")))),
                 new XElement("article",
                 new XElement("id", "2"),
                 new XElement("title", "源栈培训：C#进阶-6：异步和并行"),
                  new XElement("authorId", "1")),
                new XAttribute("isDraft", true));
            luckystack.Save("C:\\17bang\\luckystack.xml");
            XElement element = XElement.Load("C:\\17bang\\luckystack.xml");
            Console.WriteLine(element);
        }
    }
    ////随机生成一个长度为length的字符串
    //public static string GetRandomString(int length, bool useNum, bool useLow, bool useUpp, string custom)
    //{

    //    Random r = new Random();
    //    string s = null, str = custom;
    //    //根据传入的参数确定用来随机的字符串包含的字符
    //    if (useNum == true) { str += "0123456789"; }
    //    if (useLow == true) { str += "abcdefghijklmnopqrstuvwxyz"; }
    //    if (useUpp == true) { str += "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; }

    //    for (int i = 0; i < length; i++)
    //    {
    //        s += str.Substring(r.Next(0, str.Length - 1), 1);
    //    }
    //    return s;
    //}
}

