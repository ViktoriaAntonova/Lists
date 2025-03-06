using System.Collections.Generic;
using System.Xml.Linq;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinglyList<int> list = new SinglyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.PrintList();
            Node<int> middle = list.FindMiddle();
            Console.WriteLine("Средният възел е: " + middle.Data);
        }
    }
}
