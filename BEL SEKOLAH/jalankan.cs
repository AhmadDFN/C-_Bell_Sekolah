using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BEL_SEKOLAH
{
    internal class jalankan
    {
        public static void run()
        {
            // Judul
            layout.content();// ╔ ╗ ╚ ╝ ╦ ═ ║ █ ╩ ╬ ╣ ╠ ▲ ▼ ♦
            Console.CursorVisible = true;
            Console.Title = "TAMPILKAN JADWAL - iRzellA BEL SEKOLAH";
            Media.tulis(41, 13, "-♦   TAMPILKAN JADWAL   ♦-", ConsoleColor.Black, ConsoleColor.Yellow);
            Media.kotak(3, 103, 12, 27, ConsoleColor.DarkMagenta, ConsoleColor.Yellow);

            Console.CursorVisible = true;
            // Set Hari
            pengaturan.hari = "";
            do
            {
                Media.tulis(6, 15, "Masukkan Hari :", ConsoleColor.Black, ConsoleColor.Yellow);
                pengaturan.hari = Media.input(22, 15, ConsoleColor.Black, ConsoleColor.Yellow);

            } while (pengaturan.hari == "");

            // Tampilkan Kondisi Sekarang
            Console.CursorVisible = false;
            layout.content();
            Media.tulis(41, 13, "-♦   TAMPILKAN JADWAL   ♦-", ConsoleColor.Black, ConsoleColor.Yellow);
            Media.kotak(3, 103, 12, 27, ConsoleColor.DarkMagenta, ConsoleColor.Yellow);
            Media.tulis(6, 15, "Hari          : " + pengaturan.hari.ToUpper(), ConsoleColor.Black, ConsoleColor.Yellow);   
            Media.tulis(6, 16, "Tanggal       : " + DateTime.Now.ToLongDateString(), ConsoleColor.Black, ConsoleColor.Yellow);   
            Media.tulis(6, 17, "==================================================", ConsoleColor.Black, ConsoleColor.Yellow);

            // Pengecekan
            database db = new database();
            bool berhenti = false;
            while (berhenti == false)
            {
                // Cetak Jam
                Media.tulis(6, 19, "Jam           : " + DateTime.Now.ToLongTimeString(), ConsoleColor.Black, ConsoleColor.Yellow);

                // Cek Ke Database
                string sql = string.Format("SELECT * FROM tb_jadwal WHERE hari = '{0}' AND jam = #{1}#", pengaturan.hari.ToUpper(),DateTime.Now.ToLongTimeString());
                pengaturan.rsJadwal = db.GetData(sql);

                if (pengaturan.rsJadwal.Rows.Count > 0)
                {
                    Media.tulis(6, 22, "Jadwal        : " + pengaturan.rsJadwal.Rows[0]["keterangan"].ToString(), ConsoleColor.Black, ConsoleColor.Yellow);

                    // Play Sound
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = pengaturan.rsJadwal.Rows[0]["sound"].ToString();
                    player.Play();
                }

                // Loading
                Media.tulis(6, 24, "BEL SEKOLAH SEDANG DIJALANKAN", ConsoleColor.Green, ConsoleColor.Yellow);
                for (int kanan = 0;kanan < 5; kanan++)
                {
                    Media.tulis(6 + kanan*5, 26, "▓▓▓▓▓", ConsoleColor.DarkYellow, ConsoleColor.White);
                    Thread.Sleep(91);
                }for (int kiri = 0;kiri < 5; kiri++)
                {
                    Media.tulis(26 - kiri *5, 26, "░░░░░", ConsoleColor.Yellow, ConsoleColor.Cyan);
                    Thread.Sleep(91);
                }

                // Keluar

                if (Console.KeyAvailable == true)
                {
                    ConsoleKeyInfo tombol = Console.ReadKey(true);
                    if (tombol.Key == ConsoleKey.Escape)
                    {
                        berhenti = true;
                        // Bersihkan
                        layout.content();
                        Logo.stiker2(22, 14);
                    }
                }
            }
        }
    }
}
