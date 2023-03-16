using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL_SEKOLAH
{
    internal class konfirmasi
    {
        public static bool konfirm = true;
        public static void save(string text = "proses",int col = 110, int row = 18)
        {
            Console.CursorVisible = false;

            // Konfirmasi
            Media.tulis(6, 24, string.Format("Apakah ingin {0} data? ------>",text), ConsoleColor.Black, ConsoleColor.Yellow);

            // Definisi Menu
            string[] menu = new string[2];
            menu[0] = "  IYA  ";
            menu[1] = " TIDAK ";

            // Cetak Menu
            string spasikosong = new string(' ', 40);
            Console.CursorVisible = false;
            int pos = 0; // Posisi menu aktif / index
            for (int i = 0; i < menu.Length; i++)
            {
                Media.tulis(col, row + (i * 3), menu[i], ConsoleColor.Yellow, ConsoleColor.DarkCyan);
            }

            // Set menu Awal
            Media.tulis(col, row + pos * 3, menu[pos], ConsoleColor.Black, ConsoleColor.Cyan);

            // Menu Navigasi
            konfirm = true; // tanda menu jalan

            while (konfirm == true)
            {
                ConsoleKeyInfo tombol = Console.ReadKey(true);

                // Tekan Tombol Panah Bawah
                if (tombol.Key == ConsoleKey.UpArrow)
                {
                    Media.tulis(col, row + pos * 3, menu[pos], ConsoleColor.Yellow, ConsoleColor.DarkCyan);
                    pos = pos == 0 ? 0 : pos - 1; // Jika nilai pos kurang dari 0 maka nilai pos akan tetap 0 selain itu kurang 1
                    Media.tulis(col, row + pos * 3, menu[pos], ConsoleColor.Black, ConsoleColor.Cyan);
                }

                // Tekan Tombol Panah Bawah
                if (tombol.Key == ConsoleKey.DownArrow)
                {
                    Media.tulis(col, row + pos * 3, menu[pos], ConsoleColor.Yellow, ConsoleColor.DarkCyan);
                    pos = pos >= (menu.Length - 1) ? menu.Length - 1 : pos + 1; // Jika nilai pos > 4 maka tetap di posisi index ke 5
                    Media.tulis(col, row + pos * 3, menu[pos], ConsoleColor.Black, ConsoleColor.Cyan);
                }

                // Jika Enter
                if (tombol.Key == ConsoleKey.Enter)
                {
                    switch (pos)
                    {
                        case 0:
                            try
                            {
                                switch (pengaturan.posmn)
                                {
                                    case 0:
                                        create.set();
                                        break;

                                    case 1:
                                        update.set();
                                        break;

                                    case 2:
                                        delete.set();
                                        break;
                                }
                            }
                            catch (Exception err)
                            {
                                Media.tulis(6, 26, string.Format("Data gagal di{0} !",text) + err.Message.ToString(), ConsoleColor.Red, ConsoleColor.Yellow);
                            }
                            break;

                        case 1:
                            Media.tulis(6, 26, string.Format("Data batal di{0}", text), ConsoleColor.Red, ConsoleColor.Yellow);
                            break;
                    }
                    layout.sidebar();
                    ulang(text);
                }
            }
        }
        public static void ulang(string text = "proses",int col = 110, int row = 18)
        {
            Console.CursorVisible = false;
            // Konfirmasi
            Media.tulis(6, 24, string.Format("Apakah ingin mengulang {0} data? ------>", text), ConsoleColor.Black, ConsoleColor.Yellow);
            // Definisi Menu
            string[] menu = new string[2];
            menu[0] = "  IYA  ";
            menu[1] = " TIDAK ";

            // Cetak Menu
            string spasikosong = new string(' ', 40);
            Console.CursorVisible = false;
            int pos = 0; // Posisi menu aktif / index
            for (int i = 0; i < menu.Length; i++)
            {
                Media.tulis(col, row + (i * 3), menu[i], ConsoleColor.Yellow, ConsoleColor.DarkCyan);
            }

            // Set menu Awal
            Media.tulis(col, row + pos * 3, menu[pos], ConsoleColor.Black, ConsoleColor.Cyan);

            // Menu Navigasi
            bool jalan = true; // tanda menu jalan

            while (jalan == true)
            {
                ConsoleKeyInfo tombol = Console.ReadKey(true);

                // Tekan Tombol Panah Bawah
                if (tombol.Key == ConsoleKey.UpArrow)
                {
                    Media.tulis(col, row + pos * 3, menu[pos], ConsoleColor.Yellow, ConsoleColor.DarkCyan);
                    pos = pos == 0 ? 0 : pos - 1; // Jika nilai pos kurang dari 0 maka nilai pos akan tetap 0 selain itu kurang 1
                    Media.tulis(col, row + pos * 3, menu[pos], ConsoleColor.Black, ConsoleColor.Cyan);
                }

                // Tekan Tombol Panah Bawah
                if (tombol.Key == ConsoleKey.DownArrow)
                {
                    Media.tulis(col, row + pos * 3, menu[pos], ConsoleColor.Yellow, ConsoleColor.DarkCyan);
                    pos = pos >= (menu.Length - 1) ? menu.Length - 1 : pos + 1; // Jika nilai pos > 4 maka tetap di posisi index ke 5
                    Media.tulis(col, row + pos * 3, menu[pos], ConsoleColor.Black, ConsoleColor.Cyan);
                }

                // Jika Enter
                if (tombol.Key == ConsoleKey.Enter)
                {
                    switch (pos)
                    {
                        case 0:
                            jalan = false;
                            Media.block(5, 100, 25, 26, ConsoleColor.Yellow);
                            Logo.stiker7(85, 22);

                            switch (pengaturan.posmn)
                            {
                                case 0:
                                    create.run();
                                    break;

                                case 1:
                                    update.run();
                                    break;

                                case 2:
                                    delete.run();
                                    break;

                            }
                            break;

                        case 1:
                            jalan = false; // agar keluar
                            konfirm = false;
                            Media.block(5, 100, 25, 26, ConsoleColor.Yellow);
                            Logo.stiker7(85,22);
                            layout.content();
                            Media.block(109, 117, 17, 22, ConsoleColor.DarkYellow);
                            Logo.stiker2(22, 14);

                            break;
                    }
                }
            }
        }
    }
}
