/**
Task:
Write a function FindNeedle() that takes an array full of junk but containing one needle
After your function finds the needle it should return a message (as a string) that says:
Found the needle at position [index]
**/


string[] junkArray = { "poop, ", "Kacke, ", "stank, ", "needle, ", "Scheiße, ", "fart" };
Console.WriteLine(FindNeedle(junkArray));

static string FindNeedle(string[] str)
{
    foreach (string str2 in str)
    {
        Console.Write(str2 + " ");
    }
    return String.Format("\nFound the needle at index {0}", Array.IndexOf(str, "needle, "));
}
