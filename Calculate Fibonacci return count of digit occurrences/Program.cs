﻿/**
Explanation:
Fibonacci numbers are generated by setting F0 = 0, F1 = 1, and then using the formula:
Fn = Fn-2 + Fn-1

Task:
Your task is to efficiently calculate the nth element in the Fibonacci sequence and then count the occurrence of each digit in the number.
Return a list of integer pairs sorted in descending order.
10 ≤ n ≤ 100000

Examples:
f(10) = 55   returns:
[(2, 5)], as there are two occurances of digit 5

f(10000)     returns:
[(254, 3), (228, 2), (217, 6), (217, 0), (202, 5), (199, 1), (198, 7), (197, 8), (194, 4), (184, 9)]

Note:
If two integers have the same count, sort them in descending order.
Your algorithm must be efficient.
**/

while (true)
{
    long fibonacci = 1;
    long zahl1 = 0;
    long zahl2 = 1;

    //Console.WriteLine("Gib deine Zahl ein.");
    int eingabe = int.Parse(Console.ReadLine());

    for (int i = 1; i < eingabe; i++)
    {
        fibonacci = zahl1 + zahl2;
        zahl1 = zahl2;
        zahl2 = fibonacci;
    }
    Console.WriteLine(fibonacci);
}