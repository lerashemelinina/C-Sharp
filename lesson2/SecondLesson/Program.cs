using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            bool flag;
            string str;

            for (int j = 0; j < arr.Length; j++)
            {

                do
                {
                    Console.WriteLine("please insert a number");
                    str = Console.ReadLine();
                    int i;
                    for (i = 0; i < str.Length; i++)
                    {
                        //check if current char is numeric
                        if (!(str[i] >= 48 && str[i] <= 57))
                        {
                            break;
                        }
                    }

                    flag = (i == str.Length);

                } while (!flag);

                arr[j] = Convert.ToInt32(str);
            }

            Console.Write("full array is:");

            foreach (var x in arr)
            {
                Console.Write($"{x} ");
            }

            Console.WriteLine();


            for (int i = 0; i < arr.Length; i++)
            {
                if (i < (arr.Length - 1))
                {

                    if (!((arr[i] + arr[i + 1]) % 2 == 0))
                    {
                        Console.WriteLine($"{arr[i]}, {arr[i + 1]}");
                    }
                }
            }




            Console.ReadKey();

        }
    }
}
