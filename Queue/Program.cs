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

            Console.WriteLine("1 in Queue : {0}", queue.Contains(1));

            //Remove first item
            //Console.WriteLine("Remove 1 : {0}", queue.Dequeue());

            //Peek first item
            Console.WriteLine("Peek 1 : {0}", queue.Peek());

            object[] numArray = queue.ToArray();
            Console.WriteLine(String.Join( ",", numArray));

            //queue.Clear();


            foreach (object o in queue)
            {
                Console.WriteLine($"Queue :{o}");
            }


            Console.ReadLine();

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

*First in and first out that's a queue



What is Peek Method?

Returns the next available character but does not consume it.

 */