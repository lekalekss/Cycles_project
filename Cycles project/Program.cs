using System.ComponentModel.Design;

namespace Cycles_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i + " is even number");
                else
                    Console.WriteLine(i + " is odd number");
            }

            int count = 1;

            while (count <= 10)
            {

                if (count % 3 == 0)
                    Console.WriteLine(count + " is multiple of 3");
                else
                    Console.WriteLine(count + " is non-multiple of 3");
                count++;
            }

            int guess = 0;
            bool guessnum = false;
            do
            {
                Console.WriteLine("enter the number");
                string number = Console.ReadLine();
                int num = int.Parse(number);

                if (num < 5)
                {
                    Console.WriteLine("guessed number lower");
                    continue;
                }

                else if (num > 5)
                {
                    Console.WriteLine("guessed number higher");
                    continue;
                }

                else if (num == 5)
                {
                    guessnum = true;
                    Console.WriteLine("guessed right!!!!");
                    break;
                }

            }
            while (!guessnum);


            int[] numbers = new int[] { 10, 20, 30, 40, 50 };

            foreach (int number in numbers)
            {
                if (number > 30)
                    Console.WriteLine(number + " number more than 30");
                else if (number < 30)
                    Console.WriteLine(number + " number lower than 30");
                else if (number == 30)
                    Console.WriteLine(number + " number equal 30");

            }



            




        }
    }
}
