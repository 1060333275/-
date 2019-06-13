using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
namespace _0._0
{
    class Program
    {

        static void Main(string[] args)
        {
            Random s = new Random();
            Random n = new Random();
            int tall = 100;
            int wide = 200;

            string str = GetRandomString(4, true, true, true, "");
            Bitmap img = new Bitmap(wide, tall);
            Graphics g = Graphics.FromImage(img);
            g.Clear(Color.Yellow);
            g.DrawString(str, new Font("黑体", 50), new SolidBrush(Color.Red), new PointF(wide/8, tall/6));
            for (int i = 0; i < tall*10; i++)
            {
                img.SetPixel(n.Next(wide), n.Next(tall), Color.Black);
            }
            for (int i = 0; i < tall/10; i++)
            {
                g.DrawLine(new Pen(Color.Black), s.Next(wide), s.Next(tall), n.Next(wide), n.Next(tall));
            }


            img.Save(@"d:\vs\验证码.jpg", ImageFormat.Jpeg);
        }
        public static string GetRandomString(int length, bool useNum, bool useLow, bool useUpp, string custom)
        {
            byte[] b = new byte[4];
            new System.Security.Cryptography.RNGCryptoServiceProvider().GetBytes(b);
            Random r = new Random(BitConverter.ToInt32(b, 0));
            string s = null, str = custom;
            if (useNum == true) { str += "0123456789"; }
            if (useLow == true) { str += "abcdefghijklmnopqrstuvwxyz"; }
            if (useUpp == true) { str += "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; }
            for (int i = 0; i < length; i++)
            {
                s += str.Substring(r.Next(0, str.Length - 1), 1);
            }
            return s;
        }
    }
}
