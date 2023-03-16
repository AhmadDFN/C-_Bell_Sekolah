using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace BEL_SEKOLAH
{
    internal class database
    {
        OleDbConnection koneksi;

        public database()
        {
            // Test Koneksi
            string strkon = "Provider=Microsoft.Ace.OleDB.12.0;Data Source = db_jadwal.accdb";

            koneksi = new OleDbConnection(strkon);
            koneksi.Open();
        }

        public void Execute(string sql)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = koneksi;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        public DataTable GetData(string sql)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = koneksi;
            cmd.CommandText = sql;
            
            OleDbDataReader reader = cmd.ExecuteReader();
            DataTable rs = new DataTable();
            rs.Load(reader);

            return rs;
        }
    }
}
