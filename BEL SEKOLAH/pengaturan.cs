using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL_SEKOLAH
{
    internal class pengaturan
    {
        // DB Lama
        public static int posmn = 0;

        public static DataTable rsJadwal;

        public static int id;

        public static string hari;
        public static string jam;
        public static string keterangan;
        public static string sound;

        //New
        public static string nHari;
        public static string nJam;
        public static string nKeterangan;
        public static string nSound;

        // Setting username password
        public static string username;
        public static string password;
        public static string nickname;
    }
}
