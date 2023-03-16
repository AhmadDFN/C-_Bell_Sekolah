using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BEL_SEKOLAH
{
    internal class Dashboard
    {
        public static void lg_wearnes(int col,int row)
        {
            string[] lg_wearnes = new string[5];

            lg_wearnes[0] = "█████████████████████████████████████████████████";
            lg_wearnes[1] = "█▄─█▀▀▀█─▄█▄─▄▄─██▀▄─██▄─▄▄▀█▄─▀█▄─▄█▄─▄▄─█─▄▄▄▄█";
            lg_wearnes[2] = "██─█─█─█─███─▄█▀██─▀─███─▄─▄██─█▄▀─███─▄█▀█▄▄▄▄─█";
            lg_wearnes[3] = "▀▀▄▄▄▀▄▄▄▀▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▀▄▄▀▄▄▄▀▀▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀";
            lg_wearnes[4] = "█████████████████████████████████████████████████";

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            for (int i = 0; i < lg_wearnes.Length; i++)
            {
                Console.SetCursorPosition(col, row + i);
                Console.WriteLine(lg_wearnes[i]);
            }
        }
    }
}
