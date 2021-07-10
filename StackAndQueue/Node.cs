using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class Node
    {
        public Node next;
        public int data;
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
