using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Object> list = new LinkedList<Object>();
            for (int i = 0; i < 10; i++)
            {
                list.Push(i);
            }
            list.Print();
        }
    }
}