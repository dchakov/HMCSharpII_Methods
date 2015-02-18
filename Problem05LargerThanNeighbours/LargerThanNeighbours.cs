//Problem 5. Larger than neighbours• Write a method that checks if the element at given position in given array of integers
//is larger than its two neighbours (when such exist).

using System;

class LargerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("Please, enter array of numbers separated by space");
        string text = Console.ReadLine();
        string[] elements = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("Please, enter number between 0 and {0}", elements.Length - 1);
        int indexOfNumber = int.Parse(Console.ReadLine());

        int[] myArray = new int[elements.Length];
        for (int i = 0; i < elements.Length; i++)
        {
            myArray[i] = int.Parse(elements[i]); 
        }

        switch (CheckElemnent(indexOfNumber,myArray))
        {
            case 1: Console.WriteLine("Element has just one neighbour"); break;
            case 4: Console.WriteLine("Element is out of current range"); break;
            case 2: Console.WriteLine("Element {0} with index {1} is larger than neighbours",myArray[indexOfNumber],indexOfNumber); break;
            case 3: Console.WriteLine("Element {0} with index {1} is NOT larger than neighbours", myArray[indexOfNumber], indexOfNumber); break;

        }
        Console.WriteLine();
    }
    static int CheckElemnent(int elementPosition, int[] array)
    {
        if (elementPosition == 0 || elementPosition == array.Length - 1)
        {
            return 1;
        }
        else if (elementPosition < 0 || elementPosition > array.Length - 1)
        {
            return 4;
        }
        else if (array[elementPosition] > array[elementPosition - 1] && array[elementPosition] > array[elementPosition + 1])
        {
            return 2;
        }
        else
        {
            return 3;
        }
    }
}