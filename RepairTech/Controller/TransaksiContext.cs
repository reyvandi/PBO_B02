using System;
using System.Data;
using Npgsql;
using PROJECT_PBO.Model;

namespace PROJECT_PBO.Controller
{
    internal class TransaksiContext : DatabaseWrapper
    {
        private static string table = "transaksi";

        public static DataTable GetTransaksiByAkun(int id_akun)
        {
            string query = @"
                SELECT 
                    t.tanggal, 
                    t.laptop, 
                    k.nama AS teknisi, 
                    t.alamat, 
                    t.status_transaksi 
                FROM transaksi t
                JOIN teknisi k ON t.id_teknisi = k.id_teknisi
                WHERE t.id_akun = @id_akun
                ORDER BY t.tanggal DESC";

            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@id_akun", id_akun)
            };

            return queryExecutor(query, parameters);
        }

        // Method untuk menambahkan transaksi baru
        public static int AddTransaksi(M_Transaksi transaksiBaru)
        {
            string query = $@"
                INSERT INTO {table} (tanggal, laptop, id_akun, id_teknisi, alamat, status_transaksi)
                VALUES (@tanggal, @laptop, @id_akun, @id_teknisi, @alamat, @status_transaksi)
                RETURNING id_transaksi";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@tanggal", transaksiBaru.tanggal),
                new NpgsqlParameter("@laptop", transaksiBaru.laptop),
                new NpgsqlParameter("@id_akun", transaksiBaru.id_akun),
                new NpgsqlParameter("@id_teknisi", transaksiBaru.id_teknisi),
                new NpgsqlParameter("@alamat", transaksiBaru.alamat),
                new NpgsqlParameter("@status_transaksi", transaksiBaru.status_transaksi)
            };

            // Eksekusi query dan kembalikan ID transaksi
            return executeScalar(query, parameters);
        }

        // Method untuk mengambil semua transaksi
        public static DataTable All()
        {
            string query = $@"
                SELECT * FROM {table}
                ORDER BY tanggal DESC";

            return queryExecutor(query);
        }
    }
}
