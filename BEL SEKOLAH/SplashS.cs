using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BEL_SEKOLAH
{
    internal static class SplashS
    {
        public static void screen()
        {
            string[] welcome = new string[14];   

            welcome[0]  = "   ▄█     █▄     ▄████████  ▄█        ▄████████  ▄██████▄     ▄▄▄▄███▄▄▄▄      ▄████████    ";
            welcome[1]  = "  ███     ███   ███    ███ ███       ███    ███ ███    ███  ▄██▀▀▀███▀▀▀██▄   ███    ███    ";
            welcome[2]  = "  ███     ███   ███    █▀  ███       ███    █▀  ███    ███  ███   ███   ███   ███    █▀     ";
            welcome[3]  = "  ███     ███  ▄███▄▄▄     ███       ███        ███    ███  ███   ███   ███  ▄███▄▄▄        ";
            welcome[4]  = "  ███     ███ ▀▀███▀▀▀     ███       ███        ███    ███  ███   ███   ███ ▀▀███▀▀▀        ";
            welcome[5]  = "  ███     ███   ███    █▄  ███       ███    █▄  ███    ███  ███   ███   ███   ███    █▄     ";
            welcome[6]  = "  ███ ▄█▄ ███   ███    ███ ███▌    ▄ ███    ███ ███    ███  ███   ███   ███   ███    ███    ";
            welcome[7]  = "   ▀███▀███▀    ██████████ █████▄▄██ ████████▀   ▀██████▀    ▀█   ███   █▀    ██████████    ";
            welcome[8]  = "                                            TO                                              ";
            welcome[9]  = "         _____ __ __    _____ _____ __    _____ _____ _____ _____ _____ _____ _____         ";
            welcome[10] = "        |     |  |  |  |  _  |  _  |  |  |     |     |  _  |_   _|     |     |   | |        ";
            welcome[11] = "        | | | |_   _|  |     |   __|  |__|-   -|   --|     | | | |-   -|  |  | | | |        ";
            welcome[12] = "        |_|_|_| |_|    |__ __|__|  |_____|_____|_____|__|__| |_| |_____|_____|_|___|        ";
            welcome[13] = "                           Created by       ►►      iRzellA                                 ";

            for (int i = 0; i < welcome.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition(15, 7 + i);
                Console.WriteLine(welcome[i]);
                Thread.Sleep(200);
            }
            Console.ResetColor();
            Console.Clear();
        }
    }
}
