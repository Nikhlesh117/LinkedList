using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Linked List");

            LinkedList linked = new LinkedList();

            linked.Sort(56);
            linked.Sort(30);
            linked.Sort(40);
            linked.Sort(70);
            Console.Write("Ordered sequence of ");
            linked.Display();
        }
    }
}