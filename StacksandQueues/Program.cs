namespace StacksandQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue Programs");
            Console.WriteLine("Choose the option of the program want to perform");
            Console.WriteLine("1. Push Operation");
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
                default:
                    Console.WriteLine("Please choose the correct option");
                    break;
            }

            Console.ReadLine();
        }
    }
}
       