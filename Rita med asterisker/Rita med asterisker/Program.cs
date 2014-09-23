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
            while (true)
            {
                // Läs in ett udda nummer mellan 1 och 79.
                byte cols = ReadOddByte();
                Console.WriteLine();

                // Kalla på metoden Rendertriangle som skapar triangeln.
                RenderTriangle(cols);

                // Fråga användaren om hen vill skapa en ny triangel eller avsluta programmet.
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("\nValfri tangent påbörjar ny beräkning - [ESC] avslutar programmet.\n");
                Console.ResetColor();
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }

        static private byte ReadOddByte()
        {
            const byte MaxCount = 79;
            while (true)
            {
                Console.Write("Ange det udda antalet asterisker <max {0}> i triangelns bas: ", MaxCount);
                byte baseCount;

                try
                {
                    baseCount = byte.Parse(Console.ReadLine());
                    if (baseCount % 2 != 1 || baseCount < 0 || baseCount > MaxCount)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("FEl! Det inmatade värdet är inte ett udda heltal mellan 1 och {0}.", MaxCount);
                        Console.ResetColor();
                    }
                    else
                    {
                        return baseCount;
                    }
                }
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("FEl! Otillåten inmatning.");
                    Console.ResetColor();
                }
                catch (OverflowException)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("FEl! Otillåten inmatning.");
                    Console.ResetColor();
                }
            }
        }

        static void RenderTriangle(byte cols)
        {
            const string space = " ";
            const string star = "*";
            for (int row = 1; row <= (cols + 1) / 2; row++)
            {
                for (int blankSpace = cols - row; blankSpace > cols / 2; blankSpace--)
                {
                    Console.Write(space);
                }

                for (int asterisk = 0; asterisk <= (row - 1) * 2; ++asterisk)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }
        }
    }

}