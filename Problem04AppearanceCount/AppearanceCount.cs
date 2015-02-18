//Problem 4. Appearance count• Write a method that counts how many times given number appears in given array.
//• Write a test program to check if the method is workings correctly.

using System;

class AppearanceCount
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter number");
        int numberN = int.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter numbers separated by space");
        string text = Console.ReadLine();

        string[] elements = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
      
        int rezult = CounterMetod(numberN, elements);
        Console.WriteLine();
        Console.WriteLine("{0} times number {1} appears in array ", rezult,numberN);

        if (MethodChecker(rezult))
        {
            Console.WriteLine("Metod is workings correctly");
        }
        else
        { 
            Console.WriteLine("Metod is NOT workings correctly");
        }
        Console.WriteLine();
        
    }

    static bool MethodChecker(int rezult)
    {
        string[] test = new string[9] { "2", "3", "4", "5", "3", "3", "3", "3", "3" };
        int testNumber = 3;
        int testCounter = 6;
        if (CounterMetod(testNumber,test) == testCounter)
        {
            return true;  
        }
        else
        {
            return false;
        }
    }

    static int CounterMetod(int number, string[] array)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (number == int.Parse(array[i]))
            {
                counter++;  
            }   
        }
        return counter;
        
    }
}
