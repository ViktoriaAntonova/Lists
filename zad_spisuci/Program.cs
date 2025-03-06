namespace zad_spisuci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoublyLinked<int> d = new DoublyLinked<int>();
            d.Append(1);
            d.Append(2);
            d.Append(3);
            d.Append(4);
            d.Append(5);
            Console.WriteLine("Original List:");
            d.PrintList();
            d.Reverse();
            Console.WriteLine("Reversed List:");
            d.PrintList();
        }
    }
}
