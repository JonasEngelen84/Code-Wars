/**
Description:
The number 1089 is the smallest one, non palindromic, that has the same prime factors that its reversal. Thus,
prime factorization of 1089 with 3, 3, 11, 11 --> 3, 11
prime factorization of 9801 with  3, 3, 3, 3, 11, 11 --> 3, 11

Explanation:
Palindromic numbers are like: 171, 454, 4224, these ones should be discarded.

Task:
The task for this kata is to create a function same_factRev(), that receives a nMax, to find all the numbers with the above property, bellow nMax.

Note:
the function same_factRev(), will output a sorted list with the found numbers bellow nMax. Let'se some cases:
same_factRev(1100) --> [1089]
same_factRev(9999) --> [1089-2178-4356-6534-8712-9801]
**/


List<int> treffer = new();
List<int> primfaktoren = new();
List<int> primfaktoren2 = new();
List<int> primzahlen = new() { 2, 3, 5, 7, 11 };

int größe = 0;
int zwischenVar;

while (true)
{
    bool zahlEingeben = true;

    while (zahlEingeben)
    {
        Console.WriteLine("Gib eine Zahl ein, die ZWISCHEN 1088 und 10.000 ist:");
        string? eingabe = Console.ReadLine();

        try
        {
            größe = int.Parse(eingabe);
            Console.WriteLine();

            if (größe < 1089)
                Console.WriteLine("Falsche Eingabe: Die Zahl ist zu klein!");
            else if (größe > 9999)
                Console.WriteLine("Falsche Eingabe: Die Zahl ist zu groß!");
            else
                zahlEingeben = false;
        }
        catch
        {
            Console.WriteLine("\nFalsche Eingabe: Das Zahlen-Format ist nicht gültig!");
        }
    }
    treffer.Clear();
    Console.WriteLine(same_factRev(größe) + "\n\n");
}


int ZahlUmkehren(int eingabe)
{
    int ausgabe = 0;

    while (eingabe > 0)
    {
        ausgabe = ausgabe * 10 + eingabe % 10;
        eingabe /= 10;
    }
    return ausgabe;
}


string same_factRev(int größe)
{
    int zahl;
    bool berechnen = true;
    int primzahl;
    for (zahl = 1089; zahl <= größe; zahl++)
    {
        if (zahl != ZahlUmkehren(zahl))
        {
            zwischenVar = zahl;

            while (berechnen)
            {
                for (primzahl = 2; primzahl < zwischenVar; primzahl++)
                {
                    if (zwischenVar % primzahl == 0)
                    {
                        if (!primfaktoren.Contains(primzahl))
                            primfaktoren.Add(primzahl);
                        zwischenVar /= primzahl;
                        break;
                    }
                }

                if (primzahl == zwischenVar)
                {
                    berechnen = false;
                }
            }

            if (primzahlen.Contains(zwischenVar))
            {
                if (!primfaktoren.Contains(zwischenVar))
                    primfaktoren.Add(zwischenVar);

                zwischenVar = ZahlUmkehren(zahl);
                berechnen = true;
                bool istTreffer = true;

                while (berechnen)
                {
                    for (primzahl = 2; primzahl < zwischenVar; primzahl++)
                    {
                        if (zwischenVar % primzahl == 0)
                        {
                            if (!primfaktoren.Contains(primzahl))
                            {
                                istTreffer = false;
                                berechnen = false;
                                break;
                            }
                            else
                            {
                                if (!primfaktoren2.Contains(primzahl))
                                    primfaktoren2.Add(primzahl);

                                zwischenVar /= primzahl;
                                primzahl = 1;
                            }
                        }
                    }

                    if (!primfaktoren2.Contains(zwischenVar))
                    {
                        primfaktoren2.Add(zwischenVar);
                    }

                    if (primzahl == zwischenVar)
                    {
                        berechnen = false;
                    }
                }

                if (istTreffer && primfaktoren.SequenceEqual(primfaktoren2))
                    treffer.Add(zahl);
            }
            primfaktoren.Clear();
            primfaktoren2.Clear();
            berechnen = true;
        }
    }
    return string.Format($"Bis {größe} ergaben sich folgende Treffer:\n{string.Join('-', treffer)}");
}
