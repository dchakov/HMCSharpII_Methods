//Problem 1. Say Hello• Write a method that asks the user for his name and prints  “Hello, <name>”  
//• Write a program to test this method.
//Example:
//input
//output
//Peter Hello, Peter! 

using System;

class SayHello
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please,enter your name");
        string name = Console.ReadLine();

        Sayhello(name);
    }

    private static void Sayhello(string name)
    {
        Console.WriteLine("Hello, {0}",name); ;
    }
}
