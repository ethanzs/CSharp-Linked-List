using System;

namespace myApp
{
    class Node<T>
    {
        public Node<T> next { get; set; }
        public T data { get; set; }

        public Node(T data)
        {
            this.next = null;
            this.data = data;
        }

    }
}