using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBInsertionSort
{
    class Program
    {

        public static int number_checker()
        {
            try
            {
              
                int num  = Convert.ToInt32(Console.ReadLine());
             
                if (num <= 0 )
                {
                    throw new Exception("enter a valid number, not negative or 0");
                }
                else
                {
                    return num;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }

        }

        public static int choice()
        {
            Console.WriteLine("Now do you want the series to be sorted in ascending or descending order");
            Console.WriteLine("enter 1 for ascending 2 for descending");
            int num = number_checker();
            while (num== 0)
            {
                num = number_checker();
            }
            return num;
        }





        public static int[] input_checker()
        {
            Console.WriteLine("please enter the integers only, and how many do you wish?");
            int length = number_checker();
            while (length <= 0)
            {
                length = number_checker();
            }
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                String s = Console.ReadLine();
                while((int.TryParse(s, out arr[i]))== false)
                {
                    String s1 = Console.ReadLine();
                    int.TryParse(s1, out arr[i]);
                }
               
            }
            return arr;

        }


        public static int[] ascending_sorter(int[] arr)
        {
            for (int i = 0; i < arr.Length -1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        int c = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = c;
                    }
                }
            }
            return arr;

        }

        public static int[] descending_sorter(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j] > arr[j - 1])
                    {
                        int c = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = c;
                    }
                }
            }
            return arr;
        }

        public static void display(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }


        static void Main(string[] args)
        {


            int num = choice();
            //while (num != 1 || num != 2)
            //{ 
            //    num = choice();
            //}
            int[] arr = input_checker();

            if (num == 1)
            {
                arr = ascending_sorter(arr);
                Console.Write("the series after ascending order sortation is:");
            }
            else
            {
                arr = descending_sorter(arr);
                Console.Write("the series after descending order sortation is:");
            }

            display(arr);
            Console.ReadKey();





        }
    }
}
