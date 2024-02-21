using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitCounter
{
    internal class Program
    {
        static int Count(string[] digits,int a)
        {
            int Appears = digits.Count(b=>int.Parse(b)==a);
            return Appears;
        }
        static void Main(string[] args)
        {
            Console.Write("Digits -> ");
            string[] digits = Console.ReadLine().Split(',');
            Action<int> Print = b => Console.Write(b);
            for (int i = 0; i <= 9; i++)
            {
                Print(i); Console.WriteLine($" Appears {Count(digits,i)} many times");
            }
            Console.ReadKey();
        }
    }
}
