using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformPGSQL.App.Core;
using WinformPGSQL.App.Models;
using NpgsqlTypes;
namespace WinformPGSQL.App.Context
{
    internal class MahasiswaContext : DatabaseWrapper
    {
        private static string table = "mahasiswa";

        public static DataTable all()
        {
            string query = $"SELECT {table}.id, {table}.nama as Nama, {table}.nim as NIM, prodi.nama_prodi AS Prodi FROM {table} JOIN prodi ON prodi.id = {table}.prodi_id";
            DataTable dataMahasiswa = queryExecutor(query);
            return dataMahasiswa;
        }

        public static void store(M_Mahasiswa mahasiswaBaru)
        {
            string query = $"INSERT INTO {table}(nama, nim, prodi_id) VALUES(@nama, @nim, @prodi_id)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama", NpgsqlDbType.Varchar){Value = mahasiswaBaru.nama},
                new NpgsqlParameter("@nim", NpgsqlDbType.Varchar){Value = mahasiswaBaru.nim},
                new NpgsqlParameter("@prodi_id", NpgsqlDbType.Integer){Value = mahasiswaBaru.prodi_id},
            };
            commandExecutor(query, parameters);
        }

        public static void destroy(int id)
        {
            string query = $"DELETE FROM {table} WHERE id = @id";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = id},
            };
            commandExecutor(query, parameters);
        }
    }
}
