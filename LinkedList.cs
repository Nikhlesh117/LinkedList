using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
    public class LinkedList
    {
        public Node head;

        public void Add(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }

        public Node PopFirst()
        {
            if (this.head == null)
            {
                Console.WriteLine("Linked List is empty");
                return null;
            }
            Console.WriteLine("The First Node Of Data " + head.data + " is Deleted");
            this.head = this.head.next;
            return this.head;
        }

        public Node PopLast()
        {
            Node newNode = head;
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return null;
            }
            if (head.next == null)
            {
                this.head = null;
            }
            while (newNode.next.next != null)
            {
                
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }

        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("ListedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }

        
    }
}