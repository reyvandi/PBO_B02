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
    internal class DetailTransaksiContext:DatabaseWrapper
    {
        private static string table = "detail_transaksi";

        // Method untuk menambahkan detail transaksi
        public static int AddDetailTransaksi(M_DetailTransaksi detailTransaksiBaru)
        {
            string query = $@"
                INSERT INTO {table} (id_transaksi, id_jasa_perbaikan, biaya)
                VALUES (@id_transaksi, @id_jasa_perbaikan, @biaya)
                RETURNING id_detail_transaksi";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_transaksi", detailTransaksiBaru.id_transaksi),
                new NpgsqlParameter("@id_jasa_perbaikan", detailTransaksiBaru.id_jasa_perbaikan),
                new NpgsqlParameter("@biaya", detailTransaksiBaru.biaya)
            };

            // Eksekusi query dan kembalikan ID detail transaksi
            return executeScalar(query, parameters);
        }

        // Method untuk mendapatkan semua detail transaksi berdasarkan id_transaksi
        public static DataTable GetDetailTransaksiByIdTransaksi(int id_transaksi)
        {
            string query = $@"
                SELECT dt.id_detail_transaksi, dt.id_transaksi, dt.id_jasa_perbaikan, dt.biaya,
                       jp.nama_jasa
                FROM {table} dt
                JOIN jasa_perbaikan jp ON dt.id_jasa_perbaikan = jp.id_jasa_perbaikan
                WHERE dt.id_transaksi = @id_transaksi";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_transaksi", id_transaksi)
            };

            return queryExecutor(query, parameters);
        }

        // Method untuk menghapus detail transaksi berdasarkan id_detail_transaksi
        //public static int DeleteDetailTransaksi(int id_detail_transaksi)
        //{
        //    string query = $@"
        //        DELETE FROM {table}
        //        WHERE id_detail_transaksi = @id_detail_transaksi";

        //    NpgsqlParameter[] parameters =
        //    {
        //        new NpgsqlParameter("@id_detail_transaksi", id_detail_transaksi)
        //    };

        //    return executeNonQuery(query, parameters);
        //}
    }
}
