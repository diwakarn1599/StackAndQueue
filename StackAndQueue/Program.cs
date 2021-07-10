using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            StackMethods stack = new StackMethods();
            Console.WriteLine("Stack And Queue");

            stack.Push(50);
            stack.Push(76);
            stack.Push(30);
            stack.Display();
            stack.Peek();
        }
    }
}
