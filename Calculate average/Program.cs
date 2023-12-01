/**
Task:
Write a function which calculates the average of the numbers in a given list.

Note:
Empty arrays should return 0.
**/

int[] intArray = { 1, 9, 23, 14, 6, 0, 7, 6 };

Console.WriteLine($"Tha average of {ShowNums(intArray)} is: {GetAverage(intArray)}");

static string ShowNums(int[] array)
{
    string showNums = "";
    int i = 1;

    foreach (int num in array)
    {
        if (i < array.Length)
            showNums += num + ", ";
        else
            showNums += "and " + num;
        i++;
    }
    return showNums;
}

static float GetAverage(int[] array)
{
    float average = 0;
    foreach (int i in array)
    {
        average += i;
    }

    return average / array.Length;
}
