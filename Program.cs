using System;

namespace ConsoleApp50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ваша сумма вклада: ");
            double n = Convert.ToDouble(Console.ReadLine());
            if (n < 100)
            {
                n = (n/100)*5;
                Console.WriteLine(n);
            }
            else
            {
                if (n >= 100 && n <= 200)
                {
                    n = (n/100)*7;
                    Console.WriteLine(n);
                }
                else
                {
                    if (n > 200)
                    {
                        n = (n/100)*10;
                        Console.WriteLine(n);
                    }
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }
                }
            }

        }
    }
}
