using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class StackMethods
    {
        Node top;

        //Method to push data
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


        public void Peek()
        {
            if(this.top == null)
            {
                Console.WriteLine("Stack doesn't contains any value");
            }
            else
            {
                Console.WriteLine($"Top element of stack is {this.top.data}");
            }
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack doesn't contains any value");
            }
            else
            {
                
                Console.WriteLine($"Popped element => {top.data}");
                top = top.next;
            }
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
