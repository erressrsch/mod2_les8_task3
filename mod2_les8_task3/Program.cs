using System;

class Program
{
    static void Main ()
    {
        int a = 0;
        int b = 1;
        int c = 0;

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"F{i} = {c}");

            a = b;
            b = c;
            c = a + b;
        }
    }
}
