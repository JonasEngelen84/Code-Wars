// Task:
// In this kata you have to write a simple Morse code decoder.

using System.Text;

Dictionary<string, string> morsecode = new Dictionary<string, string>()
{
    {"A", ".-" }, {"B", "-..." }, {"C", "-.-." }, {"D", "-.." }, {"E", "." },
    {"F", "..-." }, {"G", "--." }, {"H",  "...."}, {"I", ".." }, {"J", ".---" },
    {"K", "-.-" }, {"L", ".-.." }, {"M", "--" }, {"N", "-." }, {"O", "---" },
    {"P", ".--." }, {"Q", "--.-" }, {"R", ".-." }, {"S", "..." }, {"T", "-" },
    {"U", "..-" }, {"V", "...-" }, {"W", ".--" }, {"X", "-..-" }, {"Y","-.--"  },
    {"Z", "--.." }, {"Ä", ".-.-" }, {"Ö", "---." }, {"Ü", "..--" }, {"ß", "......" },
    {"0", "-----" }, {"1", ".----" }, {"2", ",,..." }, {"3", ",,,.." }, {"4", "....-" },
    {"5", "....." }, {"6", "-...." }, {"7", "--..." }, {"8", "---.." }, {"9", "----." },
    {".", ".-.-.-" }, {",", "--..--" }, {"?", "..--.." }, {"'", ".----." }, {"!", "-.-.--" },
    {"/", "-..-." }, {"(", "-.--." }, {")", "-.--.-" }, {"&", ".-..." }, {":", "---..." },
    {";", "-.-.-." }, {"=", "-...-"}, {"+", ".-.-." }, {"-", "-....-" }, {"_", "..--.-" },
    {"\"", ".-..-." }, {"$", "...-..-" }, {"@", ".--.-."}
};


Console.WriteLine("Gib deinen Text ein.");

while (true)
{
    string satz = Console.ReadLine();
    Console.WriteLine(MorseDecoder(satz) + "\n");
}

string MorseDecoder(string eingabe)
{
    string ausgabe = null;

    for (int i = 0; i < eingabe.Length; i++)
    {
        if (eingabe[i].ToString().Equals(" "))
            ausgabe += " ";
        else
        {
            ausgabe += morsecode[eingabe[i].ToString().ToUpper()];
        }

        ausgabe += " ";
    }
    return ausgabe;
}