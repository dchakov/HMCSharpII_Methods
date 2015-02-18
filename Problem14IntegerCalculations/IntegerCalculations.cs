//Problem 14. Integer calculations
//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

using System;

namespace Problem14IntegerCalculations
{
    class IntegerCalculations
    {
        static void Main()
        {

            Console.WriteLine("Minimum in the sequence = {0}", Minumum(1, 2, 3, -4, 6, 9, 6, 4, 3, 5, -6, 8));
            Console.WriteLine("Maximum in the sequence = {0}", Maximum(1, 2, 3, -4, 6, 9, 6, 4, 3, 5, -6, 8));
            Console.WriteLine("Average of the sequence = {0:F4}", Average(4, 5, 2, 3, 9));
            Console.WriteLine("Sum of the sequence = {0}", Sum(4, 5, 2, 3));
            Console.WriteLine("Product of the sequence = {0}", Product(4, 5, 2, 3));
        }
        
        static int Minumum(params int[] myArray)
        {
            int minimum = int.MaxValue;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (minimum > myArray[i])
                {
                    minimum = myArray[i];
                }
            }
            return minimum;
        }

        static int Maximum(params int[] myArray)
        {
            int maximum = int.MinValue;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (maximum < myArray[i])
                {
                    maximum = myArray[i];
                }
            }
            return maximum;
        }

        static decimal Average(params int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            decimal average = Convert.ToDecimal(sum) / Convert.ToDecimal(array.Length);
            return average;
        }
        static int Sum(params int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        static int Product(params int[] array)
        {
            int product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            return product;
        }
    }
}
