﻿//Problem 1. Say Hello• Write a method that asks the user for his name and prints  “Hello, <name>”  
//• Write a program to test this method.
//Example:
//input
//output
//Peter Hello, Peter! 

using System;

class SayHello
{
    static void Main()
    {
        string myName = null;
        Printsayhello(myName);
    }

    static void Printsayhello(string name)
    {
        Console.WriteLine("Please,enter your name");
        name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!",name); ;
    }
}
