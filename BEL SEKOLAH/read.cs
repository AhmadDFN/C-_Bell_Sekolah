using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL_SEKOLAH
{
    internal class read
    {
        static public void run()
        {
            // Judul
            layout.content();
            Console.Title = "DATA JADWAL - iRzellA BEL SEKOLAH";
            Media.tulis(45, 13, "-♦   DATA JADWAL   ♦-", ConsoleColor.Black, ConsoleColor.Yellow);
            Media.kotak(3, 103, 12, 27, ConsoleColor.DarkMagenta, ConsoleColor.Yellow);

            // Mengambil data dari tb_jadwal
            database db = new database();
            pengaturan.rsJadwal = db.GetData("SELECT * FROM tb_jadwal");

            // Set Judul Tabel
            Media.tulis(6, 15, "┌──────┬──────────┬──────────┬───────────────────────────────┐", ConsoleColor.Magenta, ConsoleColor.Yellow);
            Media.tulis(6, 16, "│ ID   │   HARI   │    JAM   │           KETERANGAN          │", ConsoleColor.Magenta, ConsoleColor.Yellow);
            Media.tulis(6, 17, "├──────┼──────────┼──────────┼───────────────────────────────┤", ConsoleColor.Magenta, ConsoleColor.Yellow);
                                 
            // Jalankan Tampilan
            int jumlahdata = 6;                    // Data per halaman
            int hal = 1;                            // Halaman Aktif
            int pages = (pengaturan.rsJadwal.Rows.Count / jumlahdata)+(pengaturan.rsJadwal.Rows.Count % jumlahdata > 0 ? 1 : 0); // Jumlah halaman

            // Variabel untuk deteksi tombol yang di tekan
            ConsoleKeyInfo tombol;

            do
            {
                layout.content();

                // Tampilkan data
                int row = 0;
                for (int i = (hal - 1) * jumlahdata; i < (hal * jumlahdata); i++)
                {
                    if (i < pengaturan.rsJadwal.Rows.Count)
                    {
                        Media.tulis(6, 18 + row, String.Format("│ {0,4} │ {1,-8} │ {2,8} │ {3,-29} │", pengaturan.rsJadwal.Rows[i]["id_jadwal"].ToString(), pengaturan.rsJadwal.Rows[i]["hari"].ToString(), Convert.ToDateTime(pengaturan.rsJadwal.Rows[i]["jam"].ToString()).ToLongTimeString(), pengaturan.rsJadwal.Rows[i]["keterangan"].ToString()), ConsoleColor.Black, ConsoleColor.Yellow);
                        row++;
                    }
                }

                // Footer / Tutup Tabel
                Media.tulis(6, 18 + row, "└──────┴──────────┴──────────┴───────────────────────────────┘", ConsoleColor.Magenta, ConsoleColor.Yellow);

                // Keterangan navigasi
                Media.tulis(13, 27, String.Format("<< BACK ( Press Left Arrow ) | Halaman ke {0} dari {1} | ( Press Right Arrow ) NEXT >>", hal, pages), ConsoleColor.Black, ConsoleColor.Yellow);
                tombol = Console.ReadKey(true);
                switch (tombol.Key)
                {
                    case ConsoleKey.RightArrow:
                        hal = hal == pages ? pages : hal + 1;

                        break;
                    case ConsoleKey.LeftArrow:
                        hal = hal == 1 ? 1 : hal - 1;

                        break;
                    case ConsoleKey.Escape:
                        Logo.stiker7(85, 22);
                        layout.content();
                        Logo.stiker2(22, 14);

                        break;
                }
            }while (tombol.Key != ConsoleKey.Escape);
        }
    }
}
