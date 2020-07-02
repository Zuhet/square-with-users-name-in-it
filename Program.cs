using System;

namespace Opgave_9_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // DK: her angiver jeg start punktet for min firkant.
            // ENG: here I set the starting point of the square 
            int startpunkt = 10;

            // DK: her tager vi imod brugerens input til højde og længde af firkanten og hvilket navn den skal vise
            // ENG: here we take the user's input to the height and length of the square and what name it should show
            Console.Write("Indtast venligst den ønsket mængde loop på top og bund pjælken ");
            int topogbund = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indtast venligst den ønsket mængde loop på højrer og venster pjælken ");
            int højrerogvenster = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indtast venligt dit navn ");
            string navn = Console.ReadLine();
            Console.Clear();

            // DK: vi bruger for løkker til at få brugerens firkant ud 
            // ENG: we use for loops to get the user's square out
            for (int i = 0; i <= topogbund; i++)
            {
                // DK: toppen af firkanten
                // ENG: the top of the square
                Console.SetCursorPosition(i+startpunkt, startpunkt);
                Console.WriteLine("*");

                // DK: bunden af firkanten
                // ENG: bottom of the square
                Console.SetCursorPosition(i+ startpunkt, startpunkt+højrerogvenster);
                Console.WriteLine("*");
            }

            for (int j = 1; j <=højrerogvenster; j++)
            {
                // DK: venster side af firkanten
                // ENG: left side of the square
                Console.SetCursorPosition(startpunkt, j+ startpunkt);
                Console.WriteLine("*");

                // DK: højrer side af firkanten
                // ENG: right side of the square
                Console.SetCursorPosition(startpunkt+topogbund, j+startpunkt);
                Console.WriteLine("*");
            }

            // DK: her laver jeg udregningen for at sikre navnet kommer til at stå i midten.
            // ENG: here I do the calculation to make sure the name is in the middle.
            int x = (topogbund - navn.Length )/ 2 ;
            int y = højrerogvenster /2;

            // DK: her bruger jeg de 2 nye variabler (x og y) til at sætte cursor så den står det korekte sted når den udskriver navnet 
            // ENG: here i use the 2 new variables (x and y) to set the cursor to the correct place when printing the name
            Console.SetCursorPosition(x+startpunkt, y+startpunkt);
            Console.Write(navn);

            Console.ReadKey();

            // Made By Zuhet
        }
    }
}
