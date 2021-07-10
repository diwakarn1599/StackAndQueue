using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class StackMethods
    {
        Node top;
        public void Push(int data)
        {
            Node temp = new Node(data);
            if(this.top == null)
            {
                temp.next = null;
            }
            else
            {
                temp.next = this.top;
            }
            this.top = temp;
        }

        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine($"|__{temp.data}__|");
                temp = temp.next;
            }
        }
    }
}
