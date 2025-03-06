using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace zad2
{
    internal class SinglyList<T>
    {
        private Node<T> head;
        public SinglyList()
        {
            head = null;
        }
        public void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }
        public Node<T> FindMiddle()
        {
            if (head == null)
            {
                return null;
            }
            Node<T> slow_ptr = head;
            Node<T> fast_ptr = head;

            while (fast_ptr != null && fast_ptr.Next != null)
            {
                slow_ptr = slow_ptr.Next;
                fast_ptr = fast_ptr.Next.Next;
            }
            return slow_ptr;
        }
        public void PrintList()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.Write(current.Data + "->");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
}
