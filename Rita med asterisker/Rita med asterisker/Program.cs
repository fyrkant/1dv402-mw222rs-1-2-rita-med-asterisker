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

            // Skriv ut 25 rader
            for (int rad = 1; rad <= 25; rad++)
            {

                // Om radnumret är ett udda tal läggs ett mellanslag in.
                if (rad % 2 != 0)
                {
                    Console.Write(" ");
                }

                // Med hjälp av en switch-sats där 
                switch (rad % 3)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;   
                }

                    for (int kolumn = 1; kolumn <= 39; kolumn++)
                    {
                        Console.Write("* ");
                    }

                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}
