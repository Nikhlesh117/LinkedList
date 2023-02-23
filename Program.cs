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
            linked.Add(40);
            linked.Add(70);
            linked.Display();
            linked.Delete(40);
            Console.Write("Final sequence\n");
            linked.Display();
            linked.Size();
        }
    }
}