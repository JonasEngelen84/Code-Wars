/**
Explanation:
A 7-segment converter is basically a fancy way of saying a component that turns a number into instructions for a digital clock display.
The display has 7 segments that look like this:
 __      __   __       __   __  __   __   __ 
|  |  |  __|  __| |_| |__  |__    | |__| |__|
|  |  | |       |   |    | |  |   | |  |    |
 ¯¯      ¯¯   ¯¯       ¯¯   ¯¯       ¯¯   ¯¯

Each segment is turned on or off to form a number from 0 to 9.
The instruction it takes is in the form of a single binary stream that looks something like this: 1011010
Each bit tells the display if the corresponding segment should be on or off.

The bits for each segment are in the following order, from right to left (Binary always reads from right to left!):
Top Horizontal - Middle Horizontal - Bottom Horizontal - Top-Left Vertical - Top-Right Vertical - Bottom-Left Vertical - Bottom-Right Vertical

So the example instruction above, 1011010 would result in the display only showing the middle, top-left, top-right, and bottom-right segments,
forming the shape of a 4. That means that, for the number 4, your function should return 90, which has exactly the same binary representation: 1011010

Task:
Write a function, sevenSegmentNumber(number), that returns the correct binary input for the display.
If you can do this for each of the other 9 digits, you'll pass the test!
You should also throw an error if the number passed to the function is not valid, and not a single-digit number.
**/


string[] zahlenSegment =
{
    " __\n|  |\n|__|",
    "\n   |\n   |",
    " __\n __|\n|__",
    " __\n __|\n __|",
    "\n |_|\n   |",
    " __\n|__\n __|",
    " __\n|__\n|__|",
    " __\n   |\n   |",
    " __\n|__|\n|__|",
    " __\n|__|\n __|"
};


bool treffer;

while (true)
{
    while (true)
    {
        Console.WriteLine("Drücke 1 wenn du eine Binär-Eingabe machen willst\nDrücke 2 wenn du eine Dezimal-Eingabe machen willst.");
        string? userAuswahl = Console.ReadLine();

        if (userAuswahl.Equals("1"))
        {
            BinärEingabe();
            break;
        }

        else if (userAuswahl.Equals("2"))
        {
            DezimalEingabe();
            break;
        }

        else
            Console.WriteLine("Falsche Eingabe!");
    }
}

void BinärEingabe()
{
    string binärUserEingabe = "";

    bool korrekteEingabe = true;
    while (korrekteEingabe)
    {
        korrekteEingabe = false;
        Console.WriteLine("\nGib eine Binär-Zahl mit exakt 7 Bit ein.");
        binärUserEingabe = Console.ReadLine();

        foreach (char c in binärUserEingabe)
        {
            if (binärUserEingabe.Length > 7)
            {
                Console.WriteLine("Die Binär-Zahl ist zu lang!");
                korrekteEingabe = true;
                break;
            }

            else if (c != '0' && c != '1')
            {
                Console.WriteLine("Das ist kein gültiges Binär-Format!");
                korrekteEingabe = true;
                break;
            }
        }
    }
    GibZahlAnHandBinärAus(binärUserEingabe);
}

void DezimalEingabe()
{

}


string GibZahlAnHandBinärAus(string binärUserEingabe)
{
    string ausgabe = "";


    return "";
}