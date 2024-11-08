using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winform_mvc.App.Core;
using winform_mvc.App.Models;

namespace winform_mvc.App.Context
{
    internal class ProdiContext : DatabaseWrapper
    {
        private static string table = "prodi";

        public static DataTable All()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataProdi = queryExecutor(query);
            return dataProdi;
        }

        public static void AddProdi(M_Prodi newProdi)
        {
            string query = $"INSERT INTO {table} (nama_prodi) values (@nama_prodi)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_prodi", NpgsqlDbType.Varchar){Value = newProdi.nama_prodi},
            };
            commandExecutor(query, parameters);
        }

        public static void UpdateProdi(M_Prodi editProdi)
        {
            string query = $"UPDATE {table} SET nama_prodi = @nama_prodi WHERE id = @id";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_prodi", NpgsqlDbType.Varchar){Value = editProdi.nama_prodi},
                new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = editProdi.id}
            };
            commandExecutor(query, parameters);
        }

        public static void DeleteProdi(int id)
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
