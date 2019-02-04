using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBStack
{
    class Stack
    {
        
    internal int data;
    internal Stack next;
        
    public Stack start = null;
        

    public void push(int data)
    {
        //this is to push a data in the stack
        Stack s = new Stack();
        s.data = data;
        s.next = null;
            
        if(start== null)
        {
            start = s;
        }
        else
        {
            s.next = start;
            start = s;
        }
        return;
    }

    public void pop()
    {
        //this is to pop the number out of the stack
        if(start== null)
        {
            Console.Write("the stack is already empty, eneter a value first");
            return;
        }
        else
        {
            Console.WriteLine("the poped value is:= " + start.data);
            Stack s = start.next;
            start.next = null;
            start = s;
            return;
        }
            
    }

    public void display()
    {
            if (start != null)
            {
                Console.WriteLine("this is the stack at present");
                Stack s = start;
                while (s.next != null)
                {
                    Console.WriteLine("data= " + s.data);
                }
                Console.WriteLine("data= " + s.data);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("the stack is empty");
            }
    }
        



    public static void Main(string[] args)
    {
        Stack s = new Stack();
            //pushes the element on the 
            s.push(5);
            s.pop();
            s.pop();
            s.display();
            Console.ReadKey();


    }
    }
}
