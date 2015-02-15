//Problem 3. English digit• Write a method that returns the last digit of given integer as an English word.
//Examples:
//input
//output
//512 two 
//1024 four 
//12309 nine 


using System;

class EnglishDigit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter number");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(Getlastdigit(number));
    }

    static string Getlastdigit(int number)
    {
        int lastDigit = number % 10;
        string[] digits =new string[10]{"zero","one","two","three","four","five","six","seven","eight","nine"};
        return digits[lastDigit];
    }

   
}
