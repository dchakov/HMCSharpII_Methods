//Problem 7. Reverse number• Write a method that reverses the digits of given decimal number.
//Example:
//input
//output
//256 652 

using System;
using System.Linq;

class ReverseNumber
{
    static void Main()
    {
        // 79,228,162,514,264,337,593,543,950,335 decimal max value
        Console.WriteLine("Decimal maxValue");
        Console.WriteLine(Decimal.MaxValue);
        Console.WriteLine("Please,enter a number less than Decimal maxValue");
        decimal number = decimal.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine(ConvertDecimal(number));

    }
    static decimal ConvertDecimal(decimal number)
    {
        string text = Convert.ToString(number);
        char[] toConvert = text.ToCharArray();
        Array.Reverse(toConvert);
        string output = new string(toConvert);
        decimal result = decimal.Parse(output);
        return result;

        // return new string(text.ToCharArray().Reverse().ToArray());
    }
}