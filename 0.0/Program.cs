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
            //Canvas();
            //Iu();
            arrLearn.Call();
            Console.Read();
            //Users wp = new Users
            //{Title= "源栈培训：C#进阶-7：Linq to XML",
            //  Name="wp",
            //    PassWord="1234",
            //    Body = "1212"
            //};wp.Seek("wp");
           
        }
        //static void Canvas()
        //{
        //    Random s = new Random();
        //    Random n = new Random();
        //    int tall = 100;
        //    int wide = 200;

        //    Bitmap img = new Bitmap(wide, tall);
        //    Graphics g = Graphics.FromImage(img);
        //    g.Clear(Color.Yellow);
        //    string str = GetRandomString(4, true, true, true, "");
        //    g.DrawString(str, new Font("黑体", 50), new SolidBrush(Color.Red), new PointF(wide / 8, tall / 6));

        //    for (int i = 0; i < tall * 10; i++)
        //    {
        //        img.SetPixel(n.Next(wide), n.Next(tall), Color.Black);
        //    }

        //    for (int i = 0; i < tall / 10; i++)
        //    {
        //        g.DrawLine(new Pen(Color.Black), s.Next(wide), s.Next(tall), n.Next(wide), n.Next(tall));
        //    }
        //    img.Save(@"d:\vs\验证码.jpg", ImageFormat.Jpeg);
        //}


        ////生成随机的字符串
        //public static string GetRandomString(int length, bool useNum, bool useLow, bool useUpp, string custom)
        //{

        //    Random r = new Random();
        //    string s = null, str = custom;
        //    if (useNum == true) { str += "0123456789"; }
        //    if (useLow == true) { str += "abcdefghijklmnopqrstuvwxyz"; }
        //    if (useUpp == true) { str += "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; }

        //    for (int i = 0; i < length; i++)
        //    {
        //        s += str.Substring(r.Next(0, str.Length - 1), 1);
        //    }
        //    return s;
        //}





        ////生成一个XML文件
        //static void Iu()
        //{
        //    string body = "body";
        //    string id = "id";
        //    string comment = "comment";
        //    string article = "article";
        //    string title = "title";
        //    string authorId = "authorId";
        //    string Address = "D:\\17bang\\luckystack.xml";
        //    XElement luckystack = new XElement(
        //           "articles",
        //    new XComment("以下存放所有“源栈”所有文章"),        //注释
        //    new XElement(article,
        //        new XElement(id, "1"),
        //            new XElement(title, "源栈培训：C#进阶-7：Linq to XML"),
        //            new XElement(body, "什么是XML（EXtensible Markup Language）是一种文本" +
        //            "文件格式被设计用来传输和存储数据由：标签和属性组成元素（节点），由元素组成" +
        //            "“树状结构”必须有而且只能有一个根节点其他："),
        //            new XAttribute("isDraft", false),
        //        new XElement(authorId, "1"),
        //        new XElement("publishDate", "2019/6/18 18:15"),
        //         new XElement("comments",
        //         new XElement(comment,
        //         new XElement(id, "12"),
        //          new XElement(body, "不错，赞！"),
        //           new XElement(authorId, "2"),
        //         new XAttribute("recommend", true)),
        //         new XElement(comment,
        //         new XElement(id, "14"),
        //           new XElement(body, "作业太难了"),
        //            new XElement(authorId, "3")))),
        //         new XElement(article,
        //         new XElement(id, "2"),
        //         new XElement(title, "源栈培训：C#进阶-6：异步和并行"),
        //          new XElement(authorId, "1"),
        //          new XAttribute("isDraft", true)));

        //    luckystack.Save(Address);
        //    XElement element = XElement.Load(Address);

        //    element.Add(new XElement(article,
        //          new XElement(id, "1"),
        //          new XElement(title, "新增标题"),
        //          new XElement(authorId, "5")));

        //    Console.WriteLine(element);
        //    Console.WriteLine();
        //    Console.WriteLine();
        //    Console.WriteLine();
        //    Console.WriteLine();
        //    Console.WriteLine();
        //    var Delete = from x in element.Descendants()
        //                 where x.Name == comment
        //                 where x.Value.Contains("12")
        //                 select x;
        //    foreach (var item in Delete.ToList())
        //    {
        //        item.Remove();
        //    }
        //    Console.WriteLine(element);
        //    Console.WriteLine();
        //    Console.WriteLine();
        //    Console.WriteLine();
        //    Console.WriteLine();
        //    Console.WriteLine();
        //    var Change = from x in element.Descendants()
        //                 where x.Name == article
        //                 where x.Value.Contains("2")
        //                 select x;
        //    foreach (var item in Change.ToList())
        //    {
        //        item.SetAttributeValue("isDraft", false);
        //        item.SetElementValue(title, "源栈培训：C#进阶-8：异步和并行 ");
        //    }
        //    Console.WriteLine(element);
        //    luckystack.Save(Address);
        //}




    }
    //class Users
    //{
    //    public string Title { get; set; }
    //    public  string Body { get; set; }
    //    public string Name { get; set; }
    //    public  string PassWord { get; set;}
    //    public  string Address = "C:\\17bang\\luckystack.xml";
    //    public  XElement Articles()
    //    {
    //        XElement luckystack = new XElement("articles"
    //         );
    //        return luckystack;
    //    }
    //    public  void IssueAnArticle(string name, string passWord)
    //    {
    //        DateTime Time = new DateTime();
    //        if (name == Name & passWord == PassWord)
    //        {
    //            XElement articles = Articles();
    //            articles.Add(new XElement("article",
    //                new XElement("title", Title),
    //                new XElement("name", name),
    //                new XElement("body", Body),
    //                new XElement("DateTime", Time)));
    //            articles.Save(Address);
    //            Console.WriteLine(articles);
    //        }
    //        else
    //        {
    //            //throw ;
    //        }
                
    //    }
    //    public void Comment(string name)
    //    {
    //        DateTime Time = new DateTime();

    //        XElement Comment = Articles();
    //        Comment.Add(new XElement("comment", $"{name}:", Body),
    //            new XElement("DateTime", Time));
    //        Comment.Save(Address);
    //        Console.WriteLine(Comment);
    //    }


    //    public void Seek(string name)
    //    {
    //        int i = 0;
    //        XElement element = XElement.Load(Address);
    //        var essay = from x in element.Descendants()
    //                    where x.Name == "article"
    //                    where x.Value.Contains(name)
    //                    select x;
    //        foreach (var item in essay)
    //        {
    //            i++;
    //            Console.WriteLine(item);
    //        }
           
    //        Console.WriteLine(i);
    //    }
       
    //}
}

