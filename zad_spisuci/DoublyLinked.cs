using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace zad_spisuci
{
    internal class DoublyLinked<T>
    {
        private DoublyNode<T> head;
        private DoublyNode<T> tail;
        public void Append(T data)
        {
            DoublyNode<T> newNode = new DoublyNode<T>(data);
            if (head == null)
            {
                head = newNode;
                return;
            }
            DoublyNode<T> temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
            newNode.Previous = temp;
        }
        public DoublyLinked()
        {
            head = null;
            tail = null;
        }
        public void Reverse()
        {
            DoublyNode<T> curr = head;
            DoublyNode<T> prev = null;

            while (curr != null)
            {
                prev = curr.Previous;
                curr.Previous = curr.Next;
                curr.Next = prev;
                curr = curr.Previous;
            }

            if (prev != null)
            {
                head = prev.Previous;
            }
        }
        public void PrintList()
        {
            DoublyNode<T> current = head;
            while (current != null)
            {
                Console.Write(current.Data + "<->");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
}
