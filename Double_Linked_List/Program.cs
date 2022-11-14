using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Double_Linked_List
{
    class Node
    {
        /* Node class represent the node of doubly linked list.
        * it consists of the information part and links to
        * its succeeding and preceeding
        * in term of next and previous*/
        public int noMhs;
        public string name;
        //point to the succeding node 
        public Node next;
        //pointto the precceeding node 
        public Node prev;
    }
    class DoubleLinkedList
    {
        Node START;
        //constructor
        public DoubleLinkedList()
        {
            START = null;
        }
        public void addNode()
        {
            int nim;
            string nm;
            Console.Write("Enter the roll number of the student: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Node newNode = new Node();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
