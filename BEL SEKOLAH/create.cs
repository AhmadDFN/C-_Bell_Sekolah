using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL_SEKOLAH
{
    internal class create
    {
        public static void run()
        {
            // Jalankan Tambah
            layout.content();
            Console.CursorVisible = true;
            Console.Title = "TAMBAH JADWAL - iRzellA BEL SEKOLAH";
            Media.tulis(42, 13, "-♦   Tambah Jadwal   ♦-", ConsoleColor.Black, ConsoleColor.Yellow);

            // Label Input
            Media.kotak(3, 103, 12, 27, ConsoleColor.DarkMagenta, ConsoleColor.Yellow);
            Media.tulis(6, 15, "Hari          : ", ConsoleColor.Black, ConsoleColor.Yellow);
            Media.tulis(6, 17, "Jam (JJ:MM)   : ", ConsoleColor.Black, ConsoleColor.Yellow);
            Media.tulis(6, 19, "Keterangan    : ", ConsoleColor.Black, ConsoleColor.Yellow);
            Media.tulis(6, 21, "Sound         : ", ConsoleColor.Black, ConsoleColor.Yellow);

            // Input
            pengaturan.hari = Media.input(22, 15, ConsoleColor.Black, ConsoleColor.Yellow);
            pengaturan.jam = Media.input(22, 17, ConsoleColor.Black, ConsoleColor.Yellow);
            pengaturan.keterangan = Media.input(22, 19, ConsoleColor.Black, ConsoleColor.Yellow);
            pengaturan.sound = Media.input(22, 21, ConsoleColor.Black, ConsoleColor.Yellow);

            konfirmasi.save("simpan");
        }

        public static void set()
        {
            // Simpan
            string sql = string.Format("INSERT INTO tb_jadwal(hari,jam,keterangan,sound)VALUES ('{0}','{1}','{2}','{3}')", pengaturan.hari.ToUpper(), pengaturan.jam, pengaturan.keterangan, pengaturan.sound.Replace("\"", ""));
            database db = new database();
            db.Execute(sql); // Mengirimkan perintah ke access
            Media.tulis(6, 26, "data Berhasil Disimpan !", ConsoleColor.Green, ConsoleColor.Yellow);
        }
    }
}
