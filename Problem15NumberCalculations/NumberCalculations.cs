//Problem 15.* Number calculations• Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//• Use generic method (read in Internet about generic methods in C#).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15NumberCalculations
{
    class NumberCalculations
    {
        static void Main()
        {

            Console.WriteLine("Minimum in the sequence = {0}", Minumum(1, 2.2, 3, -4.2, 6,-1, 8));
            Console.WriteLine("Maximum in the sequence = {0}", Maximum(1, 2.2, 3, -4.2, 6, -1, 8));
            Console.WriteLine("Average of the sequence = {0:F4}", Average(1, 2.2, 3, -4.2, 6, -1, 8));
            Console.WriteLine("Sum of the sequence = {0}", Sum(1, 2.2, 3, -4.2, 6, -1, 8));
            Console.WriteLine("Product of the sequence = {0}", Product(1, 2.2, -3, -4.2, 6, -1, 8));
        }

        static T Minumum<T>(params T[] myArray)
        {
            dynamic minimum = int.MaxValue;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (minimum > myArray[i])
                {
                    minimum = myArray[i];
                }
            }
            return minimum;
        }

        static T Maximum<T>(params T[] myArray)
        {
            dynamic maximum = int.MinValue;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (maximum < myArray[i])
                {
                    maximum = myArray[i];
                }
            }
            return maximum;
        }

        static T Average<T>(params T[] array)
        {
            dynamic sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum/array.Length;
        }
        static T Sum<T>(params T[] array)
        {
            dynamic sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        static T Product<T>(params T[] array)
        {
            dynamic product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            return product;
        }
    }
}
