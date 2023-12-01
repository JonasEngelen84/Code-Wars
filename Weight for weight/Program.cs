/**
Task:
Given a string with the weights of members in normal order. Can you give this string
ordered by weights of these numbers, but The weight of a number will be from now on
the sum of its digits. When two numbers have the same weight, let us class them as
if they were strings (alphabetical ordering) and not numbers:
180 is before 90 since, (both sum = 9), because 180 beginns with 1.

Note:
All numbers in the list are positive numbers and the list can be empty.
It may happen that the input string have leading, trailing whitespaces and more than
a unique whitespace between two consecutive numbers!
**/



string weights = "86 88 102 68 75 69 71 99 63 79 113 81";

Console.WriteLine($"\n Die neu sortierte Gewichtsliste gestaltet sich wie folgt:\n {WeightSort(weights).Trim()}");

string WeightSort(string weights)
{
    Console.WriteLine(weights + "\n");
    _ = weights.Trim();
    string[] gewichtArray = weights.Split(' ');
    string[] summenArray = new string[gewichtArray.Length];

    for (int i = 0; i < gewichtArray.Length; i++)
    {
        summenArray[i] = BerechneSumme(gewichtArray[i]);
    }

    for (int i = 0; i < gewichtArray.Length; i++)
    {
        Console.WriteLine(gewichtArray[i].ToString().PadLeft(3) + " = " + summenArray[i].ToString().PadLeft(2));
    }

    return Sortieren(gewichtArray, summenArray);
}


string BerechneSumme(string eingabe)
{
    int summe = 0;

    for (int i = 0; i < eingabe.Length; i++)
    {
        summe += eingabe[i] - 48;
    }
    return summe.ToString();
}


string Sortieren(string[] gewichtArray, string[] summenArray)
{
    int zwischenVar = 0;
    int index = 0;
    int länge = summenArray.Length;
    string? resultat = null;

    while (länge > 0)
    {
        for (int i = 0; i < summenArray.Length; i++)
        {
            if (summenArray[i] == null)
                continue;

            else if (int.Parse(summenArray[i]) > zwischenVar)
            {
                zwischenVar = int.Parse(summenArray[i]);
                index = i;

            }

            else if (int.Parse(summenArray[i]) == zwischenVar)
            {
                string summe1 = gewichtArray[i];
                string summe2 = gewichtArray[index];

                if (summe1[0] < summe2[0])
                {
                    zwischenVar = int.Parse(summenArray[i]);
                    index = i;
                }
            }

        }
        resultat = resultat + " " + gewichtArray[index].ToString();
        gewichtArray[index] = null;
        summenArray[index] = null;
        zwischenVar = 0;
        länge--;
    }
    return resultat.Trim();
}
