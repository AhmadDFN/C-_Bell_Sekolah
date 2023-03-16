using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL_SEKOLAH
{
    internal class delete
    {
        public static void run()
        {
            // Jalankan Delete
            layout.content(); ;
            Console.Title = "HAPUS JADWAL - iRzellA BEL SEKOLAH";
            Media.tulis(45, 13, "-♦   HAPUS JADWAL   ♦-", ConsoleColor.Black, ConsoleColor.Yellow);
            Media.kotak(3, 103, 12, 27, ConsoleColor.DarkMagenta, ConsoleColor.Yellow);

            Console.CursorVisible = true;
            // Mengambil / mencari data dari tb_jadwal
            Media.tulis(6, 15, "Masukkan ID Jadwal :", ConsoleColor.Black, ConsoleColor.Yellow);
            pengaturan.id = int.Parse(Media.input(27, 15, ConsoleColor.Black, ConsoleColor.Yellow));
            Console.CursorVisible = false;

            database db = new database();
            pengaturan.rsJadwal = db.GetData("SELECT * FROM tb_jadwal WHERE id_jadwal=" + pengaturan.id);

            if (pengaturan.rsJadwal.Rows.Count > 0)
            {
                // Bersihkan area di bawah judul
                layout.content();
                Console.CursorVisible = true;
                Media.tulis(45, 13, "-♦   HAPUS JADWAL   ♦-", ConsoleColor.Black, ConsoleColor.Yellow);
                Media.kotak(3, 103, 12, 27, ConsoleColor.DarkMagenta, ConsoleColor.Yellow);

                // Jika ada tampilkan
                Media.tulis(6, 15, "Hari                  : " + pengaturan.rsJadwal.Rows[0]["hari"].ToString(), ConsoleColor.Black, ConsoleColor.Yellow);
                Media.tulis(6, 16, "Jam                   : " + Convert.ToDateTime(pengaturan.rsJadwal.Rows[0]["jam"].ToString()).ToLongTimeString(), ConsoleColor.Black, ConsoleColor.Yellow);
                Media.tulis(6, 17, "Keterangan            : " + pengaturan.rsJadwal.Rows[0]["keterangan"].ToString(), ConsoleColor.Black, ConsoleColor.Yellow);
                Media.tulis(6, 18, "Sound                 : " + pengaturan.rsJadwal.Rows[0]["sound"].ToString(), ConsoleColor.Black, ConsoleColor.Yellow);

                konfirmasi.save("hapus");

            } else
            {
                Media.tulis(6, 26, "Data tidak ditemukan", ConsoleColor.Red, ConsoleColor.Yellow);
                konfirmasi.ulang("hapus");
            }
        }

        public static void set()
        {
            // Menentukan menghapus
            database dbhapus = new database();
            dbhapus.Execute("DELETE FROM tb_jadwal WHERE id_jadwal=" + pengaturan.id);

            Media.tulis(6, 26, "data Berhasil Dihapus !", ConsoleColor.Green, ConsoleColor.Yellow);
        }
    }
}
