using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {

            QueueMethods queue = new QueueMethods();
            Console.WriteLine("Stack And Queue");
            queue.Enqueue(30);
            queue.Enqueue(50);
            queue.Enqueue(76);
            queue.Display();
            queue.Dequeue();
            queue.Display();

        }
    }
}
