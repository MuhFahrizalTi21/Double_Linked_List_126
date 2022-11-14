using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            newNode.noMhs = nim;
            Console.Write("Enter the name of the student: ");
            nm = Console.ReadLine();
            newNode.name = nm;

            //Check if the list empty
            if(START == null || nim <= START.noMhs)
            {
                if((START != null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\nDuplicate number not allowed");
                    return;
                }
                newNode.next = START;
                if(START != null)
                    START.prev = newNode;
                newNode.prev = null;
                START = newNode;
                return;
            }
            //check if the node is to be inserted at between two node
            Node previous, current;
            for (current = previous = START; current != null && nim >= current.noMhs; previous = current, current = current.next)
            {
                if (nim == current.noMhs)
                {
                    Console.WriteLine("\nDuplicate roll number not allowed");
                    return;
                }
            }

            /* On the execution of the above for loop, prev and
             * * current will point the those nodes
             * * between wich the new node is to be inserted*/
            newNode.next = current;
            newNode.prev = previous;

            //if the node is to be inserted at the end of the list
            if(current == null )
            {
                newNode.next = null;
                previous.next = newNode;
                return ;
            }
            current.prev = newNode;
            previous.prev = newNode;
        }
        public bool search(int rollNo, ref Node previous, ref Node current)
        {
            for(previous = current= START; current!= null && 
                rollNo!= current.noMhs; previous = current, current = current.next) { }
            return (current != null);
        }
        public bool dellNode(int rollNo)
        {
            Node previous, current;
            previous = current = null;
            if(search (rollNo, ref previous, ref current)== false)
                return false;
            //The begining of data 
            if(current.next == null)
            {
                previous.next = null;
                return true;
            }
            previous.next = current.next;
            current.next.prev = previous;
            return true;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
