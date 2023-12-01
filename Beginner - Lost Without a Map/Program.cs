using System;

namespace Beginner___Lost_Without_a_Map
{
    /**
    Task:
    Given an array of integers, return a new array with each value doubled.

    Example:
    [1, 2, 3] --> [2, 4, 6]
    **/

    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 3, 4, 5 };
            int[] y = { x[0] * 2, x[1] * 2, x[2] * 2, x[3] * 2, x[4] * 2, };

            foreach (int i in x)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            foreach (int i in y)
            {
                Console.WriteLine(i);
            }

        }
    }
}
