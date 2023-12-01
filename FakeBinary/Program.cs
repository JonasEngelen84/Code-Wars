using System;

namespace FakeBinary
{
    /**
    Task:
    Given a string of digits(Ziffern), you should replace any digit below 5 with '0'
    and any digit 5 and above with '1'. Return the resulting string.

    Note:
    Input will never be an empty string.
    **/

    class Program
    {
        static void Main(string[] args)
        {
            string x = "123456789";
            Console.WriteLine(x);
            for (int i = 1; i < x.Length + 1; i++)
            {
                if (i < 5)
                    x = x.Replace((char)(i + 48), '0');
                else
                    x = x.Replace((char)(i + 48), '1');
            }
            Console.WriteLine(x + "\n");


            string y = "982671354937";
            Console.WriteLine(y);
            for (int i = 1; i < y.Length + 1; i++)
            {
                if (i < 5)
                    y = y.Replace((char)(i + 48), '0');
                else
                    y = y.Replace((char)(i + 48), '1');
            }
            Console.WriteLine(y);
        }
    }
}
