using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace BEL_SEKOLAH
{
    internal class Login
    {
        public static void run(int col = 30, int row = 12)
        {
            //Judul
            string judulmain = "Form LOGIN";
            Console.Title = judulmain;
            Media.tulis(1+(19 - 1 - judulmain.Length) / 2, 7, judulmain, ConsoleColor.White, ConsoleColor.Blue);
            string tolonglogin = "Mohon Maaf, Silahkan Login Dulu Mas atau Mbak Pengguna Aplikasi saya !!!!!!";
            Media.tulis(22 + (118 - 22 - tolonglogin.Length) / 2, 7, tolonglogin, ConsoleColor.White, ConsoleColor.Blue);
            Console.BackgroundColor = ConsoleColor.White;

            //Deklarasi
            string garis = new string('═', 40);
            bool login = true;
            while (login)
            {
                Console.CursorVisible = false;
                layout.content();

                // HIASAN
                Logo.stiker5(1 , 19);
                Logo.stiker5(74, 19);
                Logo.stiker6(31, 13);

                Logo.stiker3(10, 14);
                Logo.stiker4(80, 14);

                Media.tulis(col + 11 ,row + 2, "-===     LOGIN     ===-" ,ConsoleColor.DarkYellow ,ConsoleColor.Yellow );
                Console.SetCursorPosition(col + 11, row + 2);

                //Set Label & Field
                Media.tulis(col + 4, row + 5, "Username : ", ConsoleColor.DarkYellow, ConsoleColor.Yellow);
                Media.tulis(col + 4, row + 7, "Password : ", ConsoleColor.DarkYellow, ConsoleColor.Yellow);

                // Set Input
                Console.CursorVisible = true;
                Console.Title = "FORM LOGIN ◄↕► USER = admin, PASSWORD = admin ►► Kecil Semua";
                Console.SetCursorPosition(col + 15, row + 5);
                pengaturan.username = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(col + 15, row + 7);
                pengaturan.password = Console.ReadLine();
                database db = new database();
                pengaturan.rsJadwal = db.GetData(String.Format("SELECT * FROM tb_login WHERE username='{0}' and password='{1}'", pengaturan.username, pengaturan.password));

                if (pengaturan.rsJadwal.Rows.Count > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(col + 10, row + 12);
                    Console.WriteLine("Selamat Datang di Aplikasi!");
                    login = false;
                    Console.CursorVisible = false;
                    Loading.delaySEC(col + 22, row + 14, 3, ConsoleColor.DarkYellow, ConsoleColor.Yellow);
                    layout.menu();

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(col + 6, row + 12);
                    Console.WriteLine("user/pass yang anda masukkan salah!");
                    Console.CursorVisible = false;
                    Loading.delaySEC(col + 22, row + 14, 3, ConsoleColor.DarkYellow, ConsoleColor.Yellow);
                }
            }
        }
    }
}
