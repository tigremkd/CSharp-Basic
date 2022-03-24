using System;
using SEDC.Oop.Class06.Task01.Models;

namespace SEDC.Oop.Class06.Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double[] numbers = { 100, 105.5, -100, 0, 0.5, -0.5 };
            foreach (double number in numbers)
            {
                NumberStats(number).PrintInfo();
            }

            NumbersStatistics a = NumberStats(0.5);
            a.PrintInfo();






            Console.ReadLine();
        }

        static NumbersStatistics NumberStats(double num)
        {
            NumbersStatistics statistics = new NumbersStatistics();
            
            Console.WriteLine($"Stats for number {num}");
            if (num >= 0)
            {
               statistics.IsPositive = true;
            }
            else
            {
                statistics.IsPositive = false;
            }
            if (num != 0 && num % 2 == 0)
            {
                statistics.IsOdd = true;
            }
            else
            {
                statistics.IsOdd= false;
            }
            if (num % 1 == 0)
            {
                statistics.IsInteger = true;
            }
            else
            {
                statistics.IsInteger= false;
            }
            statistics.Number = num;
            return statistics;
        }

    }
}
