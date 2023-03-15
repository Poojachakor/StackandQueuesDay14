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

        public void Display()

        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("\nStack is Empty");
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
    

