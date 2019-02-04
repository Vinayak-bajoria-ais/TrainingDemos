using System;

namespace VBFiboPrime
{
    class FibonacciPrime
    {

        public static int numbereligibility()
        {
            try
            {
                Console.WriteLine("enter a integer, it reprsensts the number of integers you want to print");
                String s  = Console.ReadLine();
                if (int.TryParse(s, out int num))
                {
                    if (num <= 0)
                    {
                        throw new Exception("enter a valid number not negative or 0");
                    }
                    return num;
                }
                else
                {
                    throw new Exception("enter only integer number");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }

        }

        public static int[] fibonacci(int num)
        {
            int[] arr = new int[num];
            if (num == 1)
            {
                arr[0] = 0;
                return arr;
            }
            else if (num == 2)
            {
                arr[0] = 0;
                arr[1] = 1;
                return arr;
            }
            else
            {
                arr[0] = 0;
                arr[1] = 1;
                for (int i = 2; i < num; i++)
                {
                    arr[i] = arr[i - 1] + arr[i - 2];
                }
                return arr;
            }
        }

        public static String[] prime(int[] arr)
        {
            int length = arr.Length;
            String[] sarr = new String[length];
            for(int i=0; i<5; i++)
            {
                sarr[i] = arr[i].ToString();
            }
            for (int i = 5; i < arr.Length; i++)
            {
                bool flag = false;
                flag = check_prime(arr[i]);
                if (flag == false)
                {
                    sarr[i] = "Prime";
                }
                else
                {
                    sarr[i] = arr[i].ToString();
                }
            }
            return sarr;
        }

        public static bool check_prime(int num)
        {
            bool flag = false;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    flag = true;
                    return flag;
                }
            }
            return flag;
        }

        public static void display(String[] sarr)
        {
            Console.WriteLine("this is the series as per your request");
            for(int i=0; i< sarr.Length; i++)
            {
                Console.WriteLine(sarr[i]);
            }
        }

        static void Main(string[] args)
        {
            int num = numbereligibility();
            while (num == 0)
            {
                Console.WriteLine("enter a valid integer again");
                num = numbereligibility();
            }
            int[] arr = fibonacci(num);
            String[] sarr = prime(arr);
            display(sarr);
            Console.ReadKey();

        }
        


        }
    }

