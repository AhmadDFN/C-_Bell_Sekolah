using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL_SEKOLAH
{
    internal static class layout
    {
        public static void run()
        {
            Media.block(0, 57, 0, 4, ConsoleColor.DarkBlue);                        // JUDUL
            Media.block(60, 119, 0, 4, ConsoleColor.DarkBlue);                      // JUDUL
            Media.block(1, 19, 6, 9, ConsoleColor.Blue);                            // Tampil Username
            Media.block(22, 118, 6, 8, ConsoleColor.Blue);                          // Menu
            Media.block(22, 118, 9, 9, ConsoleColor.DarkBlue);                      // Note
            Media.block(1, 105, 11, 28, ConsoleColor.Yellow);                        // CONTENT
            Media.block(108, 118, 11, 28, ConsoleColor.DarkYellow);                 // Sidebar
            Media.block(0, 119, 30, 31, ConsoleColor.DarkCyan);                     // Footer

        }
        public static void content()
        {
            Media.block(1, 105, 11, 28, ConsoleColor.Yellow);
        }

        public static void menu()
        {
            Media.block(22, 118, 6, 8, ConsoleColor.Blue);
        }

        public static void sidebar()
        {
            Media.block(108, 118, 16, 20, ConsoleColor.DarkYellow);
        }

        public static void note()
        {
            Media.block(22, 118, 9, 9, ConsoleColor.DarkBlue);
        }
    }
}
