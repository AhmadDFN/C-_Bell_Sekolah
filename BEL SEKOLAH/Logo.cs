using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BEL_SEKOLAH
{
    internal class Logo
    {
        public static void wearness(int col,int row,ConsoleColor warna = ConsoleColor.White,ConsoleColor bg = ConsoleColor.Black)
        {
            string[] LGwearness = new string[3];

            LGwearness[0] = " _  _  _ _______ _______  ______ __   _ _______ _______ _______";
            LGwearness[1] = " |  |  | |______ |_____| |_____/ | \\  | |______ |______ |______";
            LGwearness[2] = " |__|__| |______ |     | |    \\_ |  \\_| |______ ______| ______|";

            for (int s = 0;s < LGwearness.Length; s++)
            {
                Media.tulis(col, row+s, LGwearness[s],warna,bg);
            }
        }

        public static void stiker(int col, int row)
        {
            string[] logo = new string[14];   // GAK JADI DIPAKAI

            logo[0]  = "╔═╗                             ╔═╗ ";
            logo[1]  = "╚═╬═════════════════════════════╬═╝ ";
            logo[2]  = "  ║                             ║   ";
            logo[3]  = "  ║  ██╗    ██╗███████╗ ██████╗ ║   ";
            logo[4]  = "  ║  ██║    ██║██╔════╝██╔════╝ ║   ";
            logo[5]  = "  ║  ██║ █╗ ██║█████╗  ██║      ║   ";
            logo[6]  = "  ║  ██║███╗██║██╔══╝  ██║      ║   ";
            logo[7]  = "  ║  ╚███╔███╔╝███████╗╚██████  ║   ";
            logo[8]  = "  ║   ╚══╝╚══╝ ╚══════╝ ╚═════╝ ║   ";
            logo[9]  = "  ║        -= iRzellA =-        ║   ";
            logo[10] = "  ║         -< V 1.0 >-         ║   ";
            logo[11] = "  ║                             ║   ";
            logo[12] = "╔═╬═════════════════════════════╬═╗ ";
            logo[13] = "╚═╝                             ╚═╝ ";

            for (int a = 0; a < logo.Length; a++)
            {
                Media.tulis(col, row + a, logo[a], ConsoleColor.DarkYellow, ConsoleColor.Yellow);
            }
        }
        public static void stiker2(int col, int row)
        {
            string[] logo = new string[11];

            logo[0] = " ";
            logo[1] = "      ██╗██████╗ ███████╗███████╗██╗     ██╗      █████╗       ";
            logo[2] = "      ██║██╔══██╗╚══███╔╝██╔════╝██║     ██║     ██╔══██╗      ";
            logo[3] = "      ██║██████╔╝  ███╔╝ █████╗  ██║     ██║     ███████║      ";
            logo[4] = "      ██║██╔══██╗ ███╔╝  ██╔══╝  ██║     ██║     ██╔══██║      ";
            logo[5] = "      ██║██║  ██║███████╗███████╗███████╗███████╗██║  ██║      ";
            logo[6] = "      ╚═╝╚═╝  ╚═╝╚══════╝╚══════╝╚══════╝╚══════╝╚═╝  ╚═╝      ";
            logo[7] = " ╔═══╗ ╔═══════════════════════════════════════════════╗ ╔═══╗ ";
            logo[8] = " ║ ║ ║ ♦          ♣  together we have fun   ♣          ♦ ║ ║ ║ ";
            logo[9] = " ║ ╚═╝ ╚═══════════════════════════════════════════════╝ ╚═╝ ║ ";
            logo[10] = " ╚══════════════════════ ◄◄ ♠ ♣ ♥ ♦ ►► ══════════════════════╝ ";

            for (int b = 0; b < logo.Length; b++)
            {
                Media.tulis(col, row + b, logo[b], ConsoleColor.DarkYellow, ConsoleColor.Yellow);
            }
        }
        public static void stiker3(int col, int Row)
        {
            string[] logo = new string[5];

            logo[0] = " ╔═════════════╗  ";
            logo[1] = " ║  ╔═══╦═══╗  ║  ";
            logo[2] = " ║██║ █ ║ █ ║██║  ";
            logo[3] = " ║  ╚═══╩═══╝  ║  ";
            logo[4] = " ║             ║  ";


            for (int a = 0; a < logo.Length; a++)
            {
                Media.tulis(col, Row + a, logo[a], ConsoleColor.DarkYellow, ConsoleColor.Yellow);
                Thread.Sleep(200);
            }
        }
        public static void stiker4(int col, int Row)
        {
            string[] logo = new string[5];

            logo[0] = " ╔═════════════╗  ";
            logo[1] = " ║  █████████  ║  ";
            logo[2] = " ║  █████████  ║  ";
            logo[3] = " ║  █████████  ║  ";
            logo[4] = " ║             ║  ";


            for (int b = 0; b < logo.Length; b++)
            {
                Media.tulis(col, Row + b, logo[b], ConsoleColor.DarkYellow, ConsoleColor.Yellow);
                Thread.Sleep(200);
            }
        }
        public static void stiker5(int col, int Row)
        {
            string[] logo = new string[9];

            logo[0] = " ═══╦═════╦═════╦═════╦═════╦══ "; 
            logo[1] = "    ║     ║     ║     ║     ║   "; 
            logo[2] = " ═╦═╩═══╦═╩═══╦═╩═══╦═╩═══╦═╩══ ";
            logo[3] = "  ║     ║     ║     ║     ║     ";
            logo[4] = " ═╩═╦═══╩═╦═══╩═╦═══╩═╦═══╩═╦══ ";
            logo[5] = "    ║     ║     ║     ║     ║   ";
            logo[6] = " ═╦═╩═══╦═╩═══╦═╩═══╦═╩═══╦═╩══ ";
            logo[7] = "  ║     ║     ║     ║     ║     ";
            logo[8] = " ═╩═════╩═════╩═════╩═════╩════ ";
                    //("Username Yang Anda Masukkan salah");
            for (int c = 0; c < logo.Length; c++)
            {
                Media.tulis(col, Row + c, logo[c], ConsoleColor.DarkMagenta, ConsoleColor.Yellow);
            }
        } 
        public static void stiker6(int col, int Row)
        {
            string[] logo = new string[15];

            logo[0]  = "╔══════════════════════════════════════════╗";  
            logo[1]  = "║                                          ║"; 
            logo[2]  = "╠══════════════════════════════════════════╣"; 
            logo[3]  = "║                                          ║"; 
            logo[4]  = "║                                          ║";
            logo[5]  = "║                                          ║";
            logo[6]  = "║                                          ║"; 
            logo[7]  = "║                                          ║"; 
            logo[8]  = "╚════╦═══╦════════════════════════╦═══╦════╝";
            logo[9]  = "     ║   ║                        ║   ║     ";
            logo[10] = "  ╔══╩═══╩════════════════════════╩═══╩══╗  ";
            logo[11] = "  ║                                      ║  ";
            logo[12] = "═╗╚══╦═══╦════════════════════════╦═══╦══╝  ";
            logo[13] = " ║   ║   ║                        ║   ║     ";
            logo[14] = "═╩═══╚═══╝════════════════════════╚═══╝═════";

            for (int d = 0; d < logo.Length; d++)
            {
                Media.tulis(col ,Row + d, logo[d] , ConsoleColor.DarkMagenta, ConsoleColor.Yellow);
            }
        }
        public static void stiker7(int col, int Row)
        {
            string[] logo = new string[5];

            logo[0] = " ╔═══════════╗  ";
            logo[1] = " ║   ╔═══╗   ║  ";
            logo[2] = " ║███║ █ ║███║  ";
            logo[3] = " ║   ╚═══╝   ║  ";
            logo[4] = " ║           ║  ";


            for (int a = 0; a < logo.Length; a++)
            {
                Media.tulis(col, Row + a, logo[a], ConsoleColor.DarkYellow, ConsoleColor.Yellow);
                Thread.Sleep(100);
            }
        }
        public static void stiker8(int col, int Row) 
        {
            string[] logo = new string[4];

            logo[0] = "█████████";
            logo[1] = "    ▲  ██";
            logo[2] = "██  ▼    ";
            logo[3] = "█████████";

            for (int b = 0; b < logo.Length; b++)
            {
                Media.tulis(col, Row + b, logo[b], ConsoleColor.Yellow, ConsoleColor.DarkYellow);
            }
        }
    }
}
