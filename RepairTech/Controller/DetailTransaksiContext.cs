using System.Data;
using Npgsql;
using PROJECT_PBO.Model;

namespace PROJECT_PBO.Controller
{
    internal class DetailTransaksiContext : DatabaseWrapper
    {
        private static string table = "detail_transaksi";

        // Menambahkan detail transaksi
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

            return executeScalar(query, parameters);
        }

        // Mendapatkan semua detail transaksi berdasarkan id_transaksi
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

        // Mendapatkan biaya dan ID jasa perbaikan berdasarkan deskripsi kerusakan
        public static M_DetailTransaksi GetKerusakanByDeskripsi(string jenis_kerusakan)
        {
            string query = "SELECT id_jasa_perbaikan, biaya FROM jasa_perbaikan WHERE jenis_kerusakan = @jenis_kerusakan";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@jenis_kerusakan", jenis_kerusakan)
            };

            DataTable result = queryExecutor(query, parameters);

            if (result.Rows.Count > 0)
            {
                return new M_DetailTransaksi
                {
                    id_jasa_perbaikan = Convert.ToInt32(result.Rows[0]["id_jasa_perbaikan"]),
                    biaya = Convert.ToDecimal(result.Rows[0]["biaya"])
                };
            }
            return null;
        }
    }
}
