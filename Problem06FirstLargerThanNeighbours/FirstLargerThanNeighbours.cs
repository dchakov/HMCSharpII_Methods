//Problem 6. First larger than neighbours• Write a method that returns the index of the first element in array that is larger than its neighbours,
//or  -1 , if there’s no such element.
//• Use the method from the previous exercise.


using System;
using System.Collections;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("Please, enter array of numbers separated by space");
        string text = Console.ReadLine();
        string[] elements = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
               
        int[] myArray = new int[elements.Length];
        for (int i = 0; i < elements.Length; i++)
        {
            myArray[i] = int.Parse(elements[i]);
        }
       
        Console.WriteLine("Index = {0}",CheckElements(myArray));
       
    }

    static int CheckElements(int[] array)
    {
        for (int i = 1; i < array.Length-1; i++)
        {
            if (array[i] > array[i-1] && array[i]>array[i+1])
            {
                return i;
            } 
        }
        return -1;
    }
}

  

