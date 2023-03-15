namespace StacksandQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue Programs");
            Console.WriteLine("Choose the option of the program want to perform");
            Console.WriteLine("1. Push Operation \n2. Peek and Pop Operation \n3. Enqueue Operation \n4. Dequeue Operation");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Stack stack = new Stack();
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Display();//56 30 70 display same as AddFirst
                    break;
                case 2:
                    Stack popStack = new Stack();
                    popStack.Push(70);
                    popStack.Push(30);
                    popStack.Push(56);
                    popStack.Display();//56 30 70
                    popStack.Peek();
                    popStack.Pop();//56
                    //Console.WriteLine(popStack.IsEmpty());
                    popStack.Display();//30 70
                    break;
                case 3:
                    Queue queue = new Queue();
                    queue.Enqueue(56);
                    queue.Enqueue(30);
                    queue.Enqueue(70);
                    queue.Display();//56 30 70 same as AddLast Head marked on the first node
                    break;
                case 4:
                    Queue dequeue = new Queue();
                    dequeue.Enqueue(56);
                    dequeue.Enqueue(30);
                    dequeue.Enqueue(70);
                    dequeue.Display();//56 30 70
                    dequeue.Dequeue();
                    dequeue.Display();//30 70
                    break;
                default:
                    Console.WriteLine("Please choose the correct option");
                    break;
            }

            Console.ReadLine();


        }
    }
}
       