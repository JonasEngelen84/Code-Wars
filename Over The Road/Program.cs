/**
Task:
You've just moved into a perfectly straight street with exactly n identical houses on either side of the road.
Naturally, you would like to find out the house number of the people on the other side of the Street.

Note:
Evens increase on the right; odds decrease on the left. House numbers start at 1 and increase without gaps.
When n = 3, 1 is opposite 6, 3 opposite 4, and 5 opposite 2.

Example:
The street looks something like this:
1|  |6
3|  |4
5|  |2
**/

Console.WriteLine("Gegenüber Hausnummer 6 liegt Hausnummer " + OverTheRoad(6, 11) + "\n");

long OverTheRoad(long adresse, long n)
{
    int j = 1;
    long k = n;
    long länge = n;

    if (n % 2 != 0)
    {
        länge += 1;
        k -= 1;
    }


    for (int i = 1; i <= (länge / 2); i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(j.ToString().PadLeft(6) + "|  |" + k.ToString().PadRight(6));
            k -= 2;
            j += 2;
        }

        else
        {
            if (i != (länge / 2))
            {
                Console.WriteLine(j.ToString().PadLeft(6) + "|  |" + k.ToString().PadRight(6));
                k -= 2;
                j += 2;
            }
            else
            {
                Console.WriteLine(j.ToString().PadLeft(6) + "|");
            }
        }
    }

    if (n % 2 != 0)
    {
        return n - adresse;
    }
    else
        return n - adresse + 1;

}
