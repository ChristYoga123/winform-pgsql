using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformPGSQL.App.Core;

namespace WinformPGSQL.App.Context
{
    internal class ProdiContext : DatabaseWrapper
    {
        /*
        - File ini berisikan kumpulan query yang akan dipakai di Form.
        - File ini berisikan:
            1. Property Table
            2. Method yang diperlukan untuk logic business di Form
        NB: Kode kumpulan query != logic business. Logic business berisikan alur dari program atau kodingan yang sifatnya lebih ke prosedural sedangkan kumpulan query disiapkan untuk membantu kode logic business di Form sehingga tidak perlu menuliskan query berulang-ulang.
        */
        private static string table = "prodi";

        public static DataTable all()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataProdi = queryExecutor(query);
            return dataProdi;
        }

        public static DataTable show(int id)
        {
            string query = $"SELECT * FROM {table} WHERE id = @id";
            // Siapkan parameter WHERE
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer){Value = id}
            };
            DataTable dataProdi = queryExecutor(query, parameters);
            return dataProdi;
        }
    }
}
