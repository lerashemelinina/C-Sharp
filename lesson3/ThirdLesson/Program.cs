using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            bool flag;
            int[] userInput = new int[5];

            for (int i = 0; i < userInput.Length; i++)
            {
                do
                {
                    flag = false;

                    Console.WriteLine("please enter a number");

                    str = Console.ReadLine();

                    foreach (char item in str)
                    {
                        if (!(item >= 48 && item <= 57))
                        {
                            flag = true;
                        }
                    }

                }
                while (flag);

                userInput[i] = Convert.ToInt32(str);
            }

            Console.WriteLine("users Array is:");

            foreach (int item in userInput)
            {
                Console.Write($"{item} ,");
            }

            Console.WriteLine();

            for (int i = 0; i < (userInput.Length - 1); i++)
            {
                if ((userInput[i] + userInput[i + 1]) % 2 == 1)
                {
                    Console.WriteLine($"{userInput[i]},{userInput[i + 1]}");
                }
            }

            Console.ReadKey();

        }
    }
}
