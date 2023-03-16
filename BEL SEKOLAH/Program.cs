using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BEL_SEKOLAH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BufferWidth = 120;
            Console.WindowHeight = 34;
            Console.CursorVisible = false;

            // Splash Screen
            //SplashS.screen();

            // Dashboard
            // Layout
            layout.run();
            
            // ********************************************** CETAK **************************************
            // Deklatasi variabel untuk cetak

            // JUDUL
            string judul1 = "BEL SEKOLAH - V1.0";
            string judul2 = "Wearnes Education Center";
            string judul3 = "JL in aja dulu nanti dipikir keri.....!";
            Media.tulis(60 + (119 - 60 - judul1.Length) / 2, 1, judul1, ConsoleColor.White, ConsoleColor.DarkBlue);
            Media.tulis(60 + (119 - 60 - judul2.Length) / 2, 2, judul2, ConsoleColor.White, ConsoleColor.DarkBlue);
            Media.tulis(60 + (119 - 60 - judul3.Length) / 2, 3, judul3, ConsoleColor.White, ConsoleColor.DarkBlue);
            Dashboard.lg_wearnes(3, 0);
            Logo.stiker8(109, 12);
            Logo.stiker8(109, 24);

            // CONTENT
            // MENU KANAN
            // Cetak Judul
            // FOOTER
            Media.tulis(8, 30, "Aplikasi penunjang hidup",ConsoleColor.White,ConsoleColor.DarkCyan);
            Media.tulis(8, 31, "Copyright iRzella", ConsoleColor.White, ConsoleColor.DarkCyan);
            
            // Login
            Login.run();

            // Welcome user
            // GET USER
            Media.tulis(23, 9, "Arrow -> Untuk menu ke kanan || Arrow <- Untuk menu ke Kiri || Tekan Enter Untuk memilih menu", ConsoleColor.White, ConsoleColor.DarkBlue);
            string weluser = "   WELLCOME   ";
            database db = new database();
            pengaturan.rsJadwal=db.GetData(String.Format("SELECT * FROM tb_login WHERE username='{0}' and password='{1}'", pengaturan.username, pengaturan.password));
            pengaturan.nickname = pengaturan.rsJadwal.Rows[0]["nickname"].ToString();

            Media.tulis(1 + (19 - 1 - weluser.Length) / 2, 7, weluser, ConsoleColor.White, ConsoleColor.Blue);
            Media.tulis(1 + (19 - 1 - pengaturan.nickname.Length) / 2, 8, pengaturan.nickname, ConsoleColor.White, ConsoleColor.Blue);

            //MENU
            sorotMN.menusorot(27, 7);
        }
    }
}
