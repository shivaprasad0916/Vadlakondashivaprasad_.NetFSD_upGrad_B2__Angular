using System;
using System.Collections.Generic;

namespace EmployeeLinkedList
{
    // Node structure
    class Node
    {
        public int EmpId;
        public string Name;
        public Node Next;

        public Node(int id, string name)
        {
            EmpId = id;
            Name = name;
            Next = null;
        }
    }

    class LinkedList
    {
        private Node head = null;

        // Insert at beginning
        public void InsertAtBeginning(int id, string name)
        {
            Node newNode = new Node(id, name);
            newNode.Next = head;
            head = newNode;
        }

        // Insert at end
        public void InsertAtEnd(int id, string name)
        {
            Node newNode = new Node(id, name);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }

        // Delete by Employee ID
        public void Delete(int id)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            // If head node needs to be deleted
            if (head.EmpId == id)
            {
                head = head.Next;
                return;
            }

            Node temp = head;
            while (temp.Next != null && temp.Next.EmpId != id)
            {
                temp = temp.Next;
            }

            if (temp.Next == null)
            {
                Console.WriteLine("Employee not found");
            }
            else
            {
                temp.Next = temp.Next.Next;
            }
        }

        // Traverse and display
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.EmpId + " - " + temp.Name);
                temp = temp.Next;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            Console.Write("Enter number of employees: ");
            int n = int.Parse(Console.ReadLine());

            // Insert at end
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter Employee ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Enter Employee Name: ");
                string name = Console.ReadLine();

                list.InsertAtEnd(id, name);
            }

            Console.Write("\nEnter Employee ID to delete: ");
            int deleteId = int.Parse(Console.ReadLine());

            list.Delete(deleteId);

            Console.WriteLine("\nEmployee List After Deletion:");
            list.Display();
        }
    }
}