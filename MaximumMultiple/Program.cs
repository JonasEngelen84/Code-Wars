using System;

namespace MaximumMultiple
{
    /**
    Task:
    Given a divisor and a bound.Find the largest integer N, such that...
    1: is divisible by divisor
    2: is less than or equal to bound
    3: is greater than 0

    Note:
    The parameters (divisor, bound) passed to the function are only positive values.It's guaranteed that a divisor is found

    Example:
    Divisor = 2   Bound = 7   N = 6

    Explanation:
    6 is divisible by 2, 6 is <= bound 7, 6 is > 0
    **/

    class Program
    {
        private static void Main(string[] args)
        {
            RunThroughArray();
            Console.ReadKey();
        }

        private static readonly int[,] divisorBoundArray = new int[5, 2]
        {
            {2,5},
            {2,6},
            {7,65},
            {4,99},
            {6,55}
        };

        public static void RunThroughArray()
        {
            int j = 0;

            for (int i = 0; i < divisorBoundArray.Length / 2; i++)
            {
                Console.WriteLine("Divisor = {0} \t Bound = {1} \t N = {2}", divisorBoundArray[i, j], divisorBoundArray[i, j + 1], MaxMultiply(divisorBoundArray[i, j], divisorBoundArray[i, j + 1]));
            }
        }

        public static int MaxMultiply(int divisor, int bound)
        {
            int y = 0;

            for (int i = 0; i <= bound; i++)
            {
                if (i % divisor == 0 & i <= bound & i > 0)
                    y = i;
            }
            return y;
        }
    }
}
