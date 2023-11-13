using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformPGSQL.App.Core;

namespace WinformPGSQL.App.Context
{
    internal class MahasiswaContext : DatabaseWrapper
    {
        private static string table = "mahasiswa";

        public static DataTable all()
        {
            string query = $"SELECT {table}.nama as Nama, {table}.nim as NIM, prodi.nama_prodi AS Prodi FROM {table} JOIN prodi ON prodi.id = {table}.prodi_id";
            DataTable dataMahasiswa = queryExecutor(query);
            return dataMahasiswa;
        }
    }
}
