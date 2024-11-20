using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using PROJECT_PBO.Controller;
using PROJECT_PBO.Model;
using PROJECT_PBO;

namespace PROJECT_PBO.Controller
{
    internal class KomponenContext:DatabaseWrapper
    {
        private static string table = "komponen";

        public static DataTable All()
        {
            string query = @"
        SELECT 
            m.id_komponen,
            m.nama_komponen,
            m.harga,
            m.stok
        From komponen m";

            DataTable dataKomponen = queryExecutor(query);
            return dataKomponen;
        }
        public static DataTable getKomponenById(int id_komponen)
        {
            string query = @"
                SELECT 
                    m.id_komponen,
                    m.nama_komponen,
                    m.harga,
                    m.stok
                FROM 
                    komponen m
                WHERE 
                    m.id_komponen = @id_komponen";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_komponen", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id_komponen }
            };

            DataTable dataKomponen = queryExecutor(query, parameters);
            return dataKomponen;
        }


        public static void AddKomponen(M_Komponen komponenBaru)
        {
            string query = $"INSERT INTO {table} (nama_komponen, harga, stok) VALUES(@nama_komponen, @harga, @stok)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_komponen", komponenBaru.nama_komponen),
                new NpgsqlParameter("@harga", komponenBaru.harga),
                new NpgsqlParameter("@stok", komponenBaru.stok)
            };

            commandExecutor(query, parameters);
        }

        public static void UpdateKomponen(M_Komponen komponen)
        {
            string query = $"UPDATE {table} SET nama_komponen = @nama_komponen, harga = @harga, stok = @stok WHERE id_komponen = @id_komponen";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_komponen", komponen.nama_komponen),
                new NpgsqlParameter("@harga", komponen.harga),
                new NpgsqlParameter("@stok", komponen.stok),
                new NpgsqlParameter("@id_komponen", komponen.id_komponen)
            };

            commandExecutor(query, parameters);
        }
    }
}
