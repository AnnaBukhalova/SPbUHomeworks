using System;
using System.Collections.Generic;

namespace CircularList // циклический односвязный список
{
    class Program
    {
        static void Main()
        {
            var list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);


            foreach (var item in list )
            {
                Console.Write(item + "\n");
            }
            Console.WriteLine();

            list.Remove(3);
            list.Remove(1);
            list.Remove(7);

            foreach (var item in list)
            {
                Console.Write(item + "\n");
            }
            Console.WriteLine();


            list.AddFirst(7);

            foreach (var item in list)
            {
                Console.Write(item + "\n");
            }
            Console.WriteLine();

            list.AddAfter(4, 8);

            foreach (var item in list)
            {
                Console.Write(item + "\n");
            }
            Console.WriteLine();




            Console.ReadLine();

            
        }
    }
}
