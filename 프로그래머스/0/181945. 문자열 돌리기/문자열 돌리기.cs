using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();
        
        foreach (char r in s) {
            Console.WriteLine(r);
        }

    }
}