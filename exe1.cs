using System;

class Lab1
{
    static void Main()
    {
        for (int i = 0; i <= 10; i++)
            Console.Write(i + (i < 10 ? "," : "\n"));
    }
}