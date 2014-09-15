using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rita_med_asterisker
{
    class Program
    {
        static void Main(string[] args)
        {

            // En första for-loop bestämmer att innehållande kod skall loopas 25 gånger.
            for (int rad = 0; rad <= 24; rad++)
            {

                // Om variabeln rad är ett udda tal läggs ett mellanslag till först på raden.
                if (rad % 2 != 0)
                {
                    Console.Write(" ");
                }

                // Med hjälp av en switch-sats bestäms färg. 
                switch (rad % 3)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;   
                }

                // En andra, nästlad, for-loop skriver ut 39 asterisker. 
                    for (int kolumn = 0; kolumn <= 38; kolumn++)
                    {
                        Console.Write("* ");
                    }

                // Färgen återställs till standard.
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}
