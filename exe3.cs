using System;

class Lab3
{
    static void Main()
    {
        int i = 0;
        do
        {
            Console.Write(i + (i < 10 ? "," : "\n"));
            i++;
        } while (i <= 10);
    }
}