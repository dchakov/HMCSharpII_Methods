//Problem 2. Get largest number• Write a method  GetMax()  with two parameters that returns the larger of two integers.
//• Write a program that reads  3  integers from the console and prints the largest of them using the method  GetMax() .

using System;

class GetLargestNumber
{
    static void Main()
    {
        Console.WriteLine("Please, enter number one");
        int numberOne = int.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter number two");
        int numberTwo = int.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter number three");
        int numberThree = int.Parse(Console.ReadLine());
       
        Console.WriteLine("Largest number is {0}", GetMax(GetMax(numberOne, numberTwo), numberThree));
    }

    static int GetMax(int firstNumber, int secondNumber)
    {
        if (firstNumber > secondNumber)
        {
            return firstNumber;
        }
        else
        {
            return secondNumber;
        }
    }
}
