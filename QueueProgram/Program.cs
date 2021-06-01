using System;
using System.Collections.Generic;

namespace QueueProgram
{
    class Program
    {
        static Queue<String> queue = new Queue<string>();

        static void Main(string[] args)
        {
            queue.Enqueue("string1");
            queue.Enqueue("string2");
            queue.Enqueue("string3");
            queue.Enqueue("string4");
          
            Console.WriteLine("please enter the string where we want to insert ");
            string pos = Console.ReadLine();
            Console.WriteLine("please enter the string to insert");
            string value = Console.ReadLine();
            queue=QueueInsertion(queue, pos, value);
            Display();
            Console.WriteLine("peek method is used to get the element that is will first come out");
            Console.WriteLine(queue.Peek());
        }
        //this method is used for inserting the elemtes between the the queue
        static Queue<string> QueueInsertion(Queue<String> q, string pos, string value) {
            Queue<string> temp = new Queue<string>();
            q.Enqueue("indicate");
            if (q.Contains(pos))
            {
                bool flag = true;
                do
                {
                    string s = q.Dequeue();
                    if (s.Equals(pos))
                    {
                        temp.Enqueue(s);
                        temp.Enqueue(value);
                        flag =true;
                    }
                    else if(s.Equals("indicate"))
                    {
                        flag = false;

                    }
                    else
                    {
                        temp.Enqueue(s);
                        flag =true;
                    }

                } while (flag);
             
            }
            return temp;
        }

        static void Display()
        {
            foreach (string i in queue)
            {
                Console.WriteLine(i);
            }

        }



    }
}
