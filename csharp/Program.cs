using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Node<string> student = new Node<string>();
            //Node<string> lc = new Node<string> { Name = "钟锦程" };
            //Node<string> wx = new Node<string> { Name = "文轩" };
            //Node<string> wf = new Node<string> { Name = "王枫" };
            //student.Add(lc);
            //student.Add(wx);
            //student.Add(wf);


        }


    }
}


public class Node<T>
{
    public int _count = 0;
    public Node<T> Previous { get; set; }
    public Node<T> Next { get; set; }
    public Node<T> Hade { get; set; }
    public Node<T> Tall { get; set; }
    public Node<T> OldTall { get; set; }
    public T Name { get; set; }
    public void Add(Node<T> node)
    {
        if (_count != 0)
        {
            Hade = node;
            Tall = node;
        }
        else
        {

        }
        OldTall=Tall;
        node.Previous = OldTall;
        OldTall.Next = node;
        Tall = node;
        _count++;
    }
}
interface IBubblingSort
{


    void Sort(int Sort);
}
interface IClimb
{

    void Sort();


}



internal class BinarySort : IBubblingSort, IClimb
{


    void IBubblingSort.Sort(int Sort)
    {

        Console.WriteLine("我是在sort");
    }

    void IClimb.Sort()
    {
        Console.WriteLine("我是在sort");
    }
}

