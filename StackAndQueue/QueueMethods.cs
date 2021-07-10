using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class QueueMethods
    {
        Node front;
        Node rear;
        public void Enqueue(int val)
        {
            Node temp = new Node(val);
            if (this.front == null)
            {
                
                this.front = temp;
                this.rear = temp;
                temp.next = null;
            }
            else
            {
                this.rear.next = temp;
                this.rear = temp;
            }
        }

        

        public void Display()
        {
            Console.WriteLine("\n");
            Node temp = this.front;
            while (temp != null)
            {
                Console.Write($"|__{temp.data}__|");
                temp = temp.next;
            }
        }
    }
}
