using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL_SEKOLAH
{
    internal static class Media
    {
        public static void tulis(int col, int row, string text, ConsoleColor warna = ConsoleColor.White, ConsoleColor bg = ConsoleColor.Black)
        {
            Console.SetCursorPosition(col, row);
            Console.ForegroundColor = warna;
            Console.BackgroundColor = bg;
            Console.WriteLine(text);
        }

        public static void kotak(int col1, int col2, int row1, int row2, ConsoleColor warna = ConsoleColor.White, ConsoleColor bg = ConsoleColor.Black)
        {
            // Garis Horizontal
            for (int c = col1; c <= col2; c++)
            {
                tulis(c, row1, "═", warna, bg);
                tulis(c, row2, "═", warna, bg);
            }

            // Garis Vertikal
            for (int r = row1; r <= row2; r++)
            {
                tulis(col1, r, "║", warna, bg);
                tulis(col2, r, "║", warna, bg);
            }

            // Garis Siku
            tulis(col1, row1, "╔", warna, bg);
            tulis(col2, row1, "╗", warna, bg);
            tulis(col1, row2, "╚", warna, bg);
            tulis(col2, row2, "╝", warna, bg);
        }

        public static void kotakBG(int col1, int col2, int row1, int row2, ConsoleColor warna = ConsoleColor.White)
        {
            // Garis Horizontal
            for (int c = col1; c <= col2; c++)
            {
                tulis(c, row1, "─", warna, warna);
                tulis(c, row2, "─", warna, warna);
            }

            // Garis Vertikal
            for (int r = row1; r <= row2; r++)
            {
                tulis(col1, r, "│", warna, warna);
                tulis(col2, r, "│", warna, warna);
            }

            // Garis Siku
            tulis(col1, row1, "┌", warna, warna);
            tulis(col2, row1, "┐", warna, warna);
            tulis(col1, row2, "└", warna, warna);
            tulis(col2, row2, "┘", warna, warna);
        }

        public static void reset()
        {
            Console.ResetColor();
            Console.Clear();
        }

        public static void block(int col1,int col2,int row1, int row2,ConsoleColor warna = ConsoleColor.Cyan)
        {
            for (int i = 0; i <= col2 - col1; i++)
            {
                for (int j = 0; j <= row2 - row1; j++)
                {
                    Media.tulis(col1 + i, row1 + j, " ", warna, warna);
                }
            }
        }

        public static string input(int col,int row, ConsoleColor warna = ConsoleColor.White, ConsoleColor bg = ConsoleColor.Black)
        {
            Console.ForegroundColor = warna;
            Console.BackgroundColor = bg;
            Console.SetCursorPosition(col, row);
            string data = Console.ReadLine();
            return data;
        }
    }
}
