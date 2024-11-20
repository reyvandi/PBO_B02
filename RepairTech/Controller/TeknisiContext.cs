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
    internal class TeknisiContext:DatabaseWrapper
    {
        private static string table = "teknisi";
        public static DataTable All()
        {
            string query = @"
        SELECT 
            m.id_teknisi,
            m.nama,
            m.keahlian,
            m.jam_kerja,
            m.alamat,
            m.no_telepon
        From teknisi m";

            DataTable dataTeknisi = queryExecutor(query);
            return dataTeknisi;
        }

        public static DataTable getTeknisiById(int id_teknisi)
        {
            string query = @"
                SELECT 
                    m.id_teknisi,
                    m.nama,
                    m.keahlian,
                    m.jam_kerja,
                    m.alamat,
                    m.no_telepon
                From 
                    teknisi m
                WHERE 
                    m.id_teknisi = @id_teknisi";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_teknisi", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id_teknisi }
            };

            DataTable dataTeknisi= queryExecutor(query, parameters);
            return dataTeknisi;
        }
        public static void AddTeknisi(M_Teknisi teknisiBaru)
        {
            string query = $"INSERT INTO {table} (nama, keahlian, jam_kerja, alamat, no_telepon) VALUES(@nama, @keahlian, @jam_kerja, @alamat, @no_telepon)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama", teknisiBaru.nama),
                new NpgsqlParameter("@keahlian", teknisiBaru.keahlian),
                new NpgsqlParameter("@jam_kerja", teknisiBaru.jam_kerja),
                new NpgsqlParameter("@alamat", teknisiBaru.alamat),
                new NpgsqlParameter("@no_telepon", teknisiBaru.no_telepon)
            };

            commandExecutor(query, parameters);
        }

        public static void UpdateTeknisi(M_Teknisi teknisi)
        {
            string query = $"UPDATE {table} SET nama = @nama, keahlian = @keahlian, jam_kerja = @jam_kerja, alamat= @alamat, no_telepon = @no_telepon WHERE id_teknisi = @id_teknisi";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama", teknisi.nama),
                new NpgsqlParameter("@keahlian", teknisi.keahlian),
                new NpgsqlParameter("@jam_kerja", teknisi.jam_kerja),
                new NpgsqlParameter("@alamat", teknisi.alamat),
                new NpgsqlParameter("@no_telepon", teknisi.no_telepon),
                new NpgsqlParameter("@id_teknisi", teknisi.id_teknisi)
            };

            commandExecutor(query, parameters);
        }
    }
}
