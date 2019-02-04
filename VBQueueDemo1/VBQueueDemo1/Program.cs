using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBQueueDemo1
{
    class Queue<T>
    {

        public T data;
        Queue<T> next;
        Queue<T> start = null;

        public void Enqueue(T data)
        {
            Queue<T> newnode = new Queue<T>();
            newnode.data = data;
            newnode.next = null;
            if(start== null)
            {
                start = newnode;
                return;
            }
            else
            {
                Queue<T> iterator = start;
                while(iterator.next!= null)
                {
                    iterator = iterator.next;
                }
                iterator.next = newnode;
                return;
            }
        }

        public void Dequeue()
        {
           if(start== null)
            {
                Console.WriteLine("enter the value first, the queue is empty at the moment");
                return;
            }
            else
            {
                //this is a queue so the removal happens from the starting of the queueu
                Queue<T> deletionnode = start;
                Console.WriteLine("the value being deleted= " + deletionnode.data);
                start = start.next;
                deletionnode.next = null;
                return;
            }
        }

        public void display()
        {
            if(start== null)
            {
                Console.WriteLine("enter something first, the queue is empty");
                return;
            }
            else
            {
                Console.WriteLine("the values of the queueu is as follows");
                Queue<T> iterator = start;
                while(iterator.next!= null)
                {
                    Console.WriteLine("the value= " + iterator.data);
                    iterator = iterator.next;
                }
                Console.WriteLine("the value= " + iterator.data);
                return;
            }
        }

    }

    class Example
    {
        static void Main(string[] args)
        {
            Queue<String> q1 = new Queue<String>();
            q1.Enqueue("vinayak");
            q1.Enqueue("bajoria");
            q1.Dequeue();
            q1.display();

            Queue<int> q2 = new Queue<int>();
            q2.Enqueue(2);
            q2.Enqueue(3);
            q2.Enqueue(2);
            q2.Enqueue(5);
            q2.Enqueue(2);
            q2.Dequeue();
            q2.display();
            Console.ReadKey();

        }
    }

}
