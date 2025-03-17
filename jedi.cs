using System;

public class Program 
{
    public static void Main()
    {
        int midichlorian; 

        // Prompting the user to enter their age
        Console.Write("Enter your midichlorian count ");

        midichlorian = Convert.ToInt32(Console.ReadLine());

        Console.Write("thats more than I thought you look like you would have a count of {0} ", midichlorian);
    }
}
