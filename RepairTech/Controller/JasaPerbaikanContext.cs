using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using PROJECT_PBO.Controller;
using PROJECT_PBO.Model;

namespace PROJECT_PBO.Controller
{
    internal class JasaPerbaikanContext:DatabaseWrapper
    {
        private static string table = "jasa_perbaikan";
        public static DataTable All()
        {
            string query = @"
        SELECT 
            m.id_jasa_perbaikan,
            m.jenis_kerusakan,
            m.solusi,
            m.biaya,
            m.estimasi_waktu
        From jasa_perbaikan m";

            DataTable dataJasaPerbaikan = queryExecutor(query);
            return dataJasaPerbaikan;
        }

        public static DataTable getJasaPerbaikanById(int id_jasa_perbaikan)
        {
            string query = @"
                SELECT 
                    m.id_jasa_perbaikan,
                    m.jenis_kerusakan,
                    m.solusi,
                    m.biaya,
                    m.estimasi_waktu
                From jasa_perbaikan m
                WHERE 
                    m.id_jasa_perbaikan = @id_jasa_perbaikan";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_jasa_perbaikan", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id_jasa_perbaikan }
            };

            DataTable dataJasaPerbaikan = queryExecutor(query, parameters);
            return dataJasaPerbaikan;
        }

        public static void AddJasaPerbaikan(M_JasaPerbaikan jasaperbaikanBaru)
        {
            string query = $"INSERT INTO {table} (jenis_kerusakan, solusi, biaya, estimasi_waktu) VALUES(@jenis_kerusakan, @solusi, @biaya, @estimasi_waktu)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@jenis_kerusakan", jasaperbaikanBaru.jenis_kerusakan),
                new NpgsqlParameter("@solusi", jasaperbaikanBaru.solusi),
                new NpgsqlParameter("@biaya", jasaperbaikanBaru.biaya),
                new NpgsqlParameter("@estimasi_waktu", jasaperbaikanBaru.estimasi_waktu)
            };

            commandExecutor(query, parameters);
        }

        public static void UpdateJasaPerbaikan(M_JasaPerbaikan jasaperbaikan)
        {
            string query = $"UPDATE {table} SET jenis_kerusakan =@jenis_kerusakan, solusi = @solusi, biaya = @biaya, estimasi_waktu = @estimasi_waktu WHERE id_jasa_perbaikan = @id_jasa_perbaikan";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@jenis_kerusakan", jasaperbaikan.jenis_kerusakan),
                new NpgsqlParameter("@solusi", jasaperbaikan.solusi),
                new NpgsqlParameter("@biaya", jasaperbaikan.biaya),
                new NpgsqlParameter("@estimasi_waktu", jasaperbaikan.estimasi_waktu),
                new NpgsqlParameter("@id_jasa_perbaikan", jasaperbaikan.id_jasa_perbaikan)
            };

            commandExecutor(query, parameters);
        }
    }
}
