/**
Task:
In this simple assignment you are given a number and have to make it negative.
The number can be negative already, in which case no change is required.
**/


int[] numbers = { 6, 9, 12, -6, 122, -7, -4, 3 };

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(MakeNegative(numbers[i]));
}

int MakeNegative(int number)
{
    if (number > 0)
        return number * -1;
    else
        return number;
}
