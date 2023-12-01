/**
Task:
You are given a string containing 0's, 1's and one or more '?', where ? is a wildcard that can be 0 or 1.
Return an array containing all the possibilities you can reach substituing the ? for a value.

Examples:
'101?' -> ['1010', '1011']
'1?1?' -> ['1010', '1110', '1011', '1111']

Note:
Don't worry about sorting the output.
Your string will never be empty.
**/


string userEingabe;
string binär = string.Empty;
List<string> möglichkeiten = new();

while (true)
{
    Console.WriteLine("Mach eine Eingabe bestehend aus 1, 0 und ?");
    userEingabe = Console.ReadLine();

    for (int i = 0; i < Math.Pow(2, AnzahlFragezeichen(userEingabe)); i++)
    {
        binär = InBinärUmwandeln(i);
        string variante = string.Empty;
        int index = 0;

        for (int j = 0; j < userEingabe.Length; j++)
        {
            if (userEingabe[j] == '?')
            {
                variante = variante + binär[index];
                index++;
            }
            else
                variante = variante + userEingabe[j];
        }
        möglichkeiten.Add(variante);
    }
    Console.WriteLine(String.Join('-', möglichkeiten) + "\n");
    möglichkeiten.Clear();
}


int AnzahlFragezeichen(string eingabe)
{
    int ausgabe = 0;

    for (int i = 0; i < eingabe.Length; i++)
    {
        if (eingabe[i] == '?')
            ausgabe++;
    }
    return ausgabe;
}


string InBinärUmwandeln(int eingabe)
{
    int padLeft = AnzahlFragezeichen(userEingabe);
    int zwischenvar;
    string binär = string.Empty;

    while (eingabe > 0)
    {
        zwischenvar = eingabe % 2;
        eingabe /= 2;
        binär = zwischenvar.ToString() + binär;
    }
    return binär.PadLeft(padLeft, '0');
}

