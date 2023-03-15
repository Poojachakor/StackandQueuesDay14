using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksandQueues
{
    internal class Stack
    {
        public Node top;
        public Stack()
        {
            top = null;
        }
        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (top == null)
            {
                top = newNode;
                Console.WriteLine("{0} Node is Inserted into Stack", newNode.data);
            }
            else
            {
                newNode.next = top;
                top = newNode;
                Console.WriteLine("{0} Node is Inserted into Stack", newNode.data);
            }
        }

        public void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
                Console.WriteLine("{0} is the top most element", top.data);
        }
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty, Pop is not posible");
            }
            else
            {
                Console.WriteLine("Value Popped is" + top.data);
                top = top.next;
            }
        }
        public bool IsEmpty()
        {
            while (top != null)
            {
                Peek();
                Pop();
            }
            return true;
        }

        public void Display()

        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine("\nDisplaying the Nodes");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
    

