using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Linked List");

            LinkedList linked = new LinkedList();

            linked.Add(56);
            linked.Add(30);
            linked.Add(70);
            linked.Display();
            linked.Search(30);
        }
    }
}