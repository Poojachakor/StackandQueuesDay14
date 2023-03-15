namespace StacksandQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue Programs");
            Console.WriteLine("Choose the option of the program want to perform");
            Console.WriteLine("1. Push Operation \n2. Peek and Pop Operation");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Stack stack = new Stack();
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Display();
                    break;
                case 2:
                    Stack popStack = new Stack();
                    popStack.Push(70);
                    popStack.Push(30);
                    popStack.Push(56);
                    popStack.Display();
                    popStack.Peek();
                    popStack.Pop();
                    //Console.WriteLine(popStack.IsEmpty());
                    popStack.Display();
                    break;
                default:
                    Console.WriteLine("Please choose the correct option");
                    break;
            }

            Console.ReadLine();
        }
    }
}
       