using System;
using System.Collections.Generic;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Queue queue = new System.Collections.Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            foreach(object o in queue)
            {
                Console.WriteLine($"Queue :{o}");
            }



        }
    }
}


/*
  What is Queue<T> Class?

Definition
Namespace:
System.Collections.Generic

Assembly:
System.Collections.dll

Represents a first-in, first-out collection of objects.




 */