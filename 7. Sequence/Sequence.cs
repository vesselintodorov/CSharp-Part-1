using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 0;
        int y = -1;

        for (int i = 1; i < 11; i++)
        {
            x = x + 2;
            y = y - 2;
            Console.Write("{" + x + "," + y + "}, ");
        }
    }
}
