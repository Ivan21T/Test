using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var quantity=double.Parse(Console.ReadLine());
            var minOdd = double.MaxValue;
            var maxOdd = double.MinValue;
            var minEven=double.MaxValue;
            var maxEven=double.MinValue;
            var sumOdd = 0;
            var sumEven = 0;
            for (int i = 1; i <= quantity; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number%2==0)
                {
                    sumEven += number;
                    if (number<minEven)
                    {
                        minEven = number;
                        Console.WriteLine("Min even = {0}",minEven);

                    }
                    else
                    {
                        Console.WriteLine("Min even = NO");
                    }
                    if (number>maxEven)
                    {
                        maxEven = number;
                        Console.WriteLine("Max even = {0}", maxEven);
                    }
                    else
                    {
                        Console.WriteLine("Max even = NO");
                    }

                }
                else
                {
                    sumOdd+=number;
                    if (number < minOdd)
                    {
                        minOdd = number;
                        Console.WriteLine("Min odd = {0}", minOdd);

                    }
                    else
                    {
                        Console.WriteLine("Min odd = NO");
                    }
                    if (number > maxOdd)
                    {
                        maxOdd = number;
                        Console.WriteLine("Max odd = {0}", maxOdd);
                    }
                    else
                    {
                        Console.WriteLine("Max odd = NO");
                    }

                }
            }
            Console.WriteLine("Even sum = {0}",sumEven);
            Console.WriteLine("Odd sum  = {0}",sumOdd);

        }
    }
}
