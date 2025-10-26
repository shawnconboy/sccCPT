using System;

class Node
{
    // this will hold data
    public int value;

    // this will point to the next node in the list
    public Node next;

    // this is the constuctor, it makes a node with a given value
    public Node(int value)
    {
        this.value = value;
        this.next = null;
    }
}

class LinkedList
{
    // first node in the list
    public Node head;

    // add new node to end of list
    public void Add(int newValue)
    {
        Node newNode = new Node(newValue);

        // if list is empty, new node will become the head
        if (head == null)
        {
            head = newNode;
        }
        // if the list is not empty, find the end
        else
        {
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }

            // attach the new node to the end
            current.next = newNode;
        }
    }

    // display all node values
    public void PrintList()
    {
        Node current = head;

        while (current != null)
        {
            Console.Write(current.value + " ");
            // move onto the next node
            current = current.next;
        }

        Console.WriteLine();
    }
}

class Program
{

    static void Main()
    {
        Console.Clear();
        LinkedList myList = new LinkedList();

        myList.Add(10);
        myList.Add(20);
        myList.Add(30);

        myList.PrintList();
    }
}