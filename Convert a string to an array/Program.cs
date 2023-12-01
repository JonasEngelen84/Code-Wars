/**
Task:
Write a function to split a string and convert it into an array of words.

Example:
I love arrays they are my favorite --> [ "I", "love", "arrays", "they", "are", "my", "favorite" ]
**/

string satz = "I love arrays they are my favorite";

string[] stringArray = satz.Split(' ');

Console.WriteLine(satz);

foreach (string str in stringArray)
{
    Console.Write(str + " ");
}
