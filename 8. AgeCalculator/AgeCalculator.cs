using System;

class Program
{
    static void Main(string[] args)
    {
            
        Console.WriteLine("Please enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("After 10 years you will be {0} years old.", age+10);

    }
}

