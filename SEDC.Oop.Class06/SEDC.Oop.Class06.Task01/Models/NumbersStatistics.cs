using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class06.Task01.Models
{
    public class NumbersStatistics
    {
        public double Number { get; set; }
        public bool IsPositive { get; set; }
        public bool IsInteger { get; set; }
        public bool IsOdd { get; set; }

        public string PrintInfo ()
        {
           
            if (IsPositive)
            {
                Console.WriteLine($"* is Positive");
            }
            else
            {
                Console.WriteLine($"* is Negative");
            }
            if (IsInteger)
            {
                Console.WriteLine($"* is Integer");
            }
            else
            {
                Console.WriteLine($"* is Decimal");
            }
            if (IsOdd)
            {
                Console.WriteLine($"* is Odd");
            }
            else
            {
                Console.WriteLine($"* is Even");
            }














            return "igor";
            
        }
        
    }
}
