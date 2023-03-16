using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL_SEKOLAH
{
    internal class update
    {
        public static void run()
        {
            // Jalankan Tambah
            layout.content();
            Console.Title = "EDIT JADWAL - iRzellA BEL SEKOLAH";
            Media.tulis(45, 13, "-♦   EDIT JADWAL   ♦-", ConsoleColor.Black, ConsoleColor.Yellow);
            Media.kotak(3, 103, 12, 27, ConsoleColor.DarkMagenta, ConsoleColor.Yellow);

            Console.CursorVisible = true;
            // Mengambil / mencari data dari tb_jadwal
            Media.tulis(6, 15, "Masukkan ID Jadwal :", ConsoleColor.Black, ConsoleColor.Yellow);
            pengaturan.id = int.Parse(Media.input(27,15,ConsoleColor.Black,ConsoleColor.Yellow));
            Console.CursorVisible = false;

            database db = new database();
            pengaturan.rsJadwal = db.GetData("SELECT * FROM tb_jadwal WHERE id_jadwal=" + pengaturan.id);

            if (pengaturan.rsJadwal.Rows.Count > 0)
            {
                // Bersihkan area di bawah judul
                layout.content();
                Console.CursorVisible = true;
                Media.tulis(45, 13, "-♦   EDIT JADWAL   ♦-", ConsoleColor.Black, ConsoleColor.Yellow);
                Media.kotak(3, 103, 12, 27, ConsoleColor.DarkMagenta, ConsoleColor.Yellow);

                // Jika ada tampilkan
                Media.tulis(15, 16, "♠  DATA LAMA  ♠", ConsoleColor.Black, ConsoleColor.Yellow);
                Media.tulis(6, 18, "Hari        : " + pengaturan.rsJadwal.Rows[0]["hari"].ToString(), ConsoleColor.Black, ConsoleColor.Yellow);
                Media.tulis(6, 19, "Jam         : " + Convert.ToDateTime(pengaturan.rsJadwal.Rows[0]["jam"].ToString()), ConsoleColor.Black, ConsoleColor.Yellow);
                Media.tulis(6, 20, "Keterangan  : " + pengaturan.rsJadwal.Rows[0]["keterangan"].ToString(), ConsoleColor.Black, ConsoleColor.Yellow);
                Media.tulis(6, 21, "Sound       : " + pengaturan.rsJadwal.Rows[0]["sound"].ToString(), ConsoleColor.Black, ConsoleColor.Yellow);

                // Label untuk data baru
                Media.tulis(73, 16, "♠  DATA BARU  ♠", ConsoleColor.Black, ConsoleColor.Yellow);
                Media.tulis(60, 18, "Hari        ( Baru ) : ", ConsoleColor.Black, ConsoleColor.Yellow);
                Media.tulis(60, 19, "Jam         ( Baru ) : ", ConsoleColor.Black, ConsoleColor.Yellow);
                Media.tulis(60, 20, "Keterangan  ( Baru ) : ", ConsoleColor.Black, ConsoleColor.Yellow);
                Media.tulis(60, 21, "Sound       ( Baru ) : ", ConsoleColor.Black, ConsoleColor.Yellow);

                // Inputan data baru
                pengaturan.nHari = Media.input(83, 18, ConsoleColor.Black, ConsoleColor.Yellow);
                pengaturan.nJam = Media.input(83, 19, ConsoleColor.Black, ConsoleColor.Yellow);
                pengaturan.nKeterangan = Media.input(83, 20, ConsoleColor.Black, ConsoleColor.Yellow);
                pengaturan.nSound = Media.input(83, 21, ConsoleColor.Black, ConsoleColor.Yellow);

                konfirmasi.save("edit");
            } else
            {
                Media.tulis(6, 26, "data tidak berhasil ditemukan !!!!", ConsoleColor.Red, ConsoleColor.Yellow);
                konfirmasi.ulang("edit");
            }

        }

        public static void set()
        {
            // Menentukan data yang akan disimpan
            pengaturan.hari = pengaturan.nHari == "" ? pengaturan.rsJadwal.Rows[0]["hari"].ToString() : pengaturan.nHari;
            pengaturan.jam = pengaturan.nJam == "" ? pengaturan.rsJadwal.Rows[0]["jam"].ToString() : pengaturan.nJam;
            pengaturan.keterangan = pengaturan.nKeterangan == "" ? pengaturan.rsJadwal.Rows[0]["keterangan"].ToString() : pengaturan.nKeterangan;
            pengaturan.sound = pengaturan.nSound == "" ? pengaturan.rsJadwal.Rows[0]["sound"].ToString() : pengaturan.nSound;

            // Proses Simpan Edit
            database dbedit = new database();
            string sql = string.Format("UPDATE tb_jadwal SET hari = '{0}',jam = '{1}',keterangan = '{2}',sound = '{3}' WHERE id_jadwal={4}",pengaturan.hari.ToUpper(),pengaturan.jam,pengaturan.keterangan,pengaturan.sound.Replace("\"",""),pengaturan.id);
            dbedit.Execute(sql);
            Media.tulis(6, 26, "data Berhasil Disimpan !", ConsoleColor.Green, ConsoleColor.Yellow);
        }
    }
}