/**
Task:
Each lowercase letter becomes uppercase and each uppercase letter becomes lowercase.
**/

Console.WriteLine("Bitte gib einen Satz ein.");
string eingabeString = Console.ReadLine();
Console.WriteLine($"Eingabestring: {eingabeString}\nAusgabestring: {BearbeiteString(eingabeString)}\n");

string BearbeiteString(string eingabeString)
{
    string? ausgabe = null;

    for (int i = 0; i < eingabeString.Length; i++)
    {
        if (eingabeString[i].Equals(' '))
            ausgabe += " ";
        else if (char.IsUpper(eingabeString[i]))
            ausgabe += char.ToLower(eingabeString[i]);
        else
            ausgabe += char.ToUpper(eingabeString[i]);
    }
    return ausgabe;
}