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
            for (int rad = 2; rad <= 25; rad++)
            {
                if (rad % 2 != 0)
                {
                    Console.Write(" ");
                }

                    for (int kolumn = 2; kolumn <= 39; kolumn++)
                    {

                        Console.Write("* ");
                    }

                Console.WriteLine();
            }



        }
        //private static byte ReadOddByte()
        //{
            
        //}
        //private static void RenderTriangle(byte cols)
        //{

        //}
    }
}
