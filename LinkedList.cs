using System;

namespace myApp
{
    class LinkedList<T>
    {
        private Node<T> head { get; set; }
        public LinkedList()
        {
            this.head = null;
        }

        public LinkedList(T data)
        {
            this.head = CreateNode(data);
        }

        public static Node<T> CreateNode(T data)
        {
            return new Node<T>(data);
        }

        public void Print()
        {
            Node<T> temp = this.head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

        public void Push(T data)
        {
            Node<T> temp = this.head;

            // Check if there is a head in list
            if (temp == null)
            {
                this.head = CreateNode(data);
                return;
            }

            // Get last node in list
            while (temp.next != null)
            {
                temp = temp.next;
            }
            // Set the new node as the next node of last node in list
            temp.next = CreateNode(data);
        }

        public int Size()
        {
            Node<T> temp = this.head;
            int size = 0;
            while (temp != null)
            {
                size++;
                temp = temp.next;
            }
            return size;
        }

        public int Remove(int index)
        {
            Node<T> temp = this.head;

            if (index < this.Size() && index >= 0)
            {
                for (int i = 0; i < index - 1; i++)
                {
                    temp = temp.next;
                }
                temp.next = temp.next.next;
                return 1;
            }
            else
            {
                return -1;
            }
        }

    }
}