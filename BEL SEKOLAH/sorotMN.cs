using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL_SEKOLAH
{
    internal class sorotMN
    {
        public static void menusorot(int col, int row)
        {
            layout.content();
            Logo.stiker2(22, 14);
            string[] menu = new string[6];
            pengaturan.posmn = 0;

            menu[0] = "   TAMBAH   ";
            menu[1] = "    EDIT    ";
            menu[2] = "   HAPUS    ";
            menu[3] = "   TAMPIL   ";
            menu[4] = "  JALANKAN  ";
            menu[5] = "   KELUAR   ";

            for (int i = 0; i < menu.Length; i++)
            {
                Media.tulis(col + (3 * i) + (i * menu[i].Length), row, menu[i], ConsoleColor.Yellow, ConsoleColor.DarkBlue);
            }

            Media.tulis(col + (3 * pengaturan.posmn) + (pengaturan.posmn * menu[pengaturan.posmn].Length), row, menu[pengaturan.posmn], ConsoleColor.Yellow, ConsoleColor.Red);            

            bool jalan = true;
            do
            {
                Console.Title = "iRzellA Application || Dashboard Menu";
                ConsoleKeyInfo tombol = Console.ReadKey(true);
                Console.CursorVisible = false;

                if (tombol.Key == ConsoleKey.RightArrow)
                {
                    Media.tulis(col + (3 * pengaturan.posmn) + (pengaturan.posmn * menu[pengaturan.posmn].Length), row, menu[pengaturan.posmn], ConsoleColor.Yellow, ConsoleColor.DarkBlue);
                    pengaturan.posmn = pengaturan.posmn >= menu.Length - 1 ? menu.Length - 1 : pengaturan.posmn + 1;
                    Media.tulis(col + (3 * pengaturan.posmn) + (pengaturan.posmn * menu[pengaturan.posmn].Length), row, menu[pengaturan.posmn], ConsoleColor.Yellow, ConsoleColor.Red);
                }

                if (tombol.Key == ConsoleKey.LeftArrow)
                {
                    Media.tulis(col + (3 * pengaturan.posmn) + (pengaturan.posmn * menu[pengaturan.posmn].Length), row, menu[pengaturan.posmn], ConsoleColor.Yellow, ConsoleColor.DarkBlue);
                    pengaturan.posmn = pengaturan.posmn <= 0 ? 0 : pengaturan.posmn - 1;
                    Media.tulis(col + (3 * pengaturan.posmn) + (pengaturan.posmn * menu[pengaturan.posmn].Length), row, menu[pengaturan.posmn], ConsoleColor.Yellow, ConsoleColor.Red);
                }

                // Jika Enter
                if (tombol.Key == ConsoleKey.Enter)
                {
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
                        case 3:
                            read.run();

                            break;
                        case 4:
                            jalankan.run();

                            break;
                        case 5:
                            jalan = false; // agar keluar

                            break;
                    }
                }
            } while (jalan);
        }
    }
}
