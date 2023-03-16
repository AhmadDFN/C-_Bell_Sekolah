using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BEL_SEKOLAH
{
    internal class Loading
    {
        public static void delaySEC(int col, int row, int detik, ConsoleColor warna = ConsoleColor.White, ConsoleColor bg = ConsoleColor.Black)
        {
            for (int i = detik; i > 0; i--)
            {
                string angka;
                angka = detik.ToString();
                detik--;
                Media.tulis(col, row, angka, warna, bg);
                Thread.Sleep(1000);
            }
        }  
    }
}
