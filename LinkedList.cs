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
            Node newNode = this.head;
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

        public Node Search(int data)
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == data)
                {
                    Console.WriteLine("Given value: " + data + " is in Linked List");
                    return temp;
                }
                temp = temp.next;
            }
            if(temp == null)
            {
                Console.WriteLine("Given value: " + data + " is not in Linked List");
            }
            return null;
        }

        public void SearchAndInsert(int position, int data)
        {
            Node temp = this.head;
            Node newNode = new Node(data);

            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }

            while (temp.next != null)
            {
                if (temp.data == position)
                {
                    Console.WriteLine(newNode.data + " is inserted after " + temp.data);
                    newNode.next = temp.next;
                    temp.next = newNode;
                    break;
                }
                temp = temp.next;
            }
        }

        public void Delete(int data)
        {
            Node temp = head;

            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            while (temp.next != null)
            {
                if (temp.next.data == data)
                {
                    temp.next = temp.next.next;
                    Console.WriteLine("The value " + data + " is deleted from the Linked List");
                }
                temp = temp.next;
            }
        }

        public void Size()
        {
            int size = 0;

            Node temp = head;

            while (temp != null)
            {
                temp = temp.next;
                size++;
            }
            Console.WriteLine("Linked List size is : " + size);
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