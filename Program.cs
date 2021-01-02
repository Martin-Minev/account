using System;

namespace account
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numOfOperations = int.Parse(Console.ReadLine());
            int counter = 0;
            double total = 0.00;
            while (counter < numOfOperations)
            {
                double deposit = double.Parse(Console.ReadLine());
                if (deposit < 0.00)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {deposit:F2}");
                counter++;
                total += deposit;
            }

            Console.WriteLine($"Total:{total:F2}");
        }
    }
}
