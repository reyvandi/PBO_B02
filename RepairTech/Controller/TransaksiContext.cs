using System;
using System.Data;
using Npgsql;
using PROJECT_PBO.Model;

namespace PROJECT_PBO.Controller
{
    internal class TransaksiContext : DatabaseWrapper
    {
        private static string table = "transaksi";


        public static void TambahTransaksi(
            M_Transaksi transaksi,
            List<M_DetailTransaksi> detailTransaksi,
            List<M_DetailKomponen> detailKomponens)
        {
            // Validasi input transaksi utama
            if (string.IsNullOrWhiteSpace(transaksi.nama_pelanggan))
            {
                throw new Exception("Nama pelanggan tidak boleh kosong.");
            }

            // Query untuk menambahkan transaksi
            string queryTransaksi = @"
                INSERT INTO transaksi (nama_pelanggan, laptop, id_teknisi, tanggal, status_transaksi) 
                VALUES (@nama_pelanggan, @laptop, @id_teknisi, @tanggal, @status_transaksi) RETURNING id_transaksi;";

            DatabaseWrapper.openConnection();
            try
            {
                // Menambahkan transaksi dan mendapatkan id_transaksi
                int idTransaksi = DatabaseWrapper.executeScalar(queryTransaksi, new NpgsqlParameter[] {
                    new NpgsqlParameter("@nama_pelanggan", transaksi.nama_pelanggan),
                    new NpgsqlParameter("@laptop", transaksi.laptop ?? (object)DBNull.Value),
                    new NpgsqlParameter("@id_teknisi", transaksi.id_teknisi ?? (object)DBNull.Value),
                    new NpgsqlParameter("@tanggal", transaksi.tanggal),
                    new NpgsqlParameter("@status_transaksi", transaksi.status_transaksi)
                });

                // Menambahkan detail transaksi
                foreach (var detail in detailTransaksi)
                {
                    string queryDetail = @"
                        INSERT INTO detail_transaksi (id_transaksi, id_jasa_perbaikan, biaya)
                        VALUES (@id_transaksi, @id_jasa_perbaikan, @biaya);";

                    DatabaseWrapper.commandExecutor(queryDetail, new NpgsqlParameter[] {
                        new NpgsqlParameter("@id_transaksi", idTransaksi),
                        new NpgsqlParameter("@id_jasa_perbaikan", detail.id_jasa_perbaikan),
                        new NpgsqlParameter("@biaya", detail.biaya)
                    });
                }

                // Menambahkan detail komponen dan mengurangi stok
                foreach (var detail in detailKomponens)
                {
                    string queryKomponen = @"
                        INSERT INTO detail_komponen (id_transaksi, id_komponen, harga, jumlah)
                        VALUES (@id_transaksi, @id_komponen, @harga, @jumlah);";

                    string queryUpdateStok = @"
                        UPDATE komponen 
                        SET stok = stok - @jumlah
                        WHERE id_komponen = @id_komponen;";

                    DatabaseWrapper.commandExecutor(queryKomponen, new NpgsqlParameter[] {
                        new NpgsqlParameter("@id_transaksi", idTransaksi),
                        new NpgsqlParameter("@id_komponen", detail.id_komponen),
                        new NpgsqlParameter("@harga", detail.harga),
                        new NpgsqlParameter("@jumlah", detail.jumlah)
                    });

                    DatabaseWrapper.commandExecutor(queryUpdateStok, new NpgsqlParameter[] {
                        new NpgsqlParameter("@jumlah", detail.jumlah),
                        new NpgsqlParameter("@id_komponen", detail.id_komponen)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error saat menambahkan transaksi: {ex.Message}");
            }
            finally
            {
                DatabaseWrapper.closeConnection();
            }
        }

        // Menambahkan transaksi baru untuk pelanggan yang melakukan servis secara online
        public static int AddTransaksi(M_Transaksi transaksi)
        {
            // Query untuk memasukkan transaksi baru
            string query = $@"
                INSERT INTO {table} (nama_pelanggan, laptop, alamat, id_teknisi, tanggal, status_transaksi)
                VALUES (@nama_pelanggan, @laptop, @alamat, @id_teknisi, @tanggal, @status_transaksi)
                RETURNING id_transaksi";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_pelanggan", transaksi.nama_pelanggan),
                new NpgsqlParameter("@laptop", transaksi.laptop),
                new NpgsqlParameter("@alamat", transaksi.alamat),
                new NpgsqlParameter("@id_teknisi", transaksi.id_teknisi),
                new NpgsqlParameter("@tanggal", transaksi.tanggal),
                new NpgsqlParameter("@status_transaksi", transaksi.status_transaksi)
            };

            return executeScalar(query, parameters); // Return the ID of the newly added transaction
        }

        // Mengambil semua transaksi berdasarkan username
        public static DataTable GetTransaksiByUsername(string username)
        {
            string query = $@"
                SELECT t.tanggal, t.laptop, t.alamat, t.status_transaksi, 
                       te.nama AS teknisi
                FROM {table} t
                JOIN teknisi te ON t.id_teknisi = te.id_teknisi
                JOIN akun a ON t.nama_pelanggan = a.username
                WHERE a.username = @username";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", username)
            };

            return queryExecutor(query, parameters);
        }

        // Memperbarui status transaksi berdasarkan ID transaksi
        public static bool UpdateStatusTransaksi(int id_transaksi, string statusBaru)
        {
            string query = $@"
                UPDATE {table}
                SET status_transaksi = @statusBaru
                WHERE id_transaksi = @id_transaksi";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@statusBaru", statusBaru),
                new NpgsqlParameter("@id_transaksi", id_transaksi)
            };

            try
            {
                DatabaseWrapper.commandExecutor(query, parameters);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error saat memperbarui status transaksi: {e.Message}");
                return false;
            }
        }

        // Mengambil detail transaksi berdasarkan ID transaksi
        public static DataRow GetTransaksiById(int id_transaksi)
        {
            string query = $@"
                SELECT t.id_transaksi, t.laptop, t.alamat, t.tanggal, t.status_transaksi,
                       t.nama_pelanggan, te.nama AS teknisi
                FROM {table} t
                JOIN teknisi te ON t.id_teknisi = te.id_teknisi
                WHERE t.id_transaksi = @id_transaksi";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_transaksi", id_transaksi)
            };

            DataTable result = queryExecutor(query, parameters);
            return result.Rows.Count > 0 ? result.Rows[0] : null;
        }

        public static DataTable GetAllTransaksiWithDetails()
        {
            string query = @"
            SELECT 
                t.id_transaksi,
                t.tanggal,
                t.nama_pelanggan,
                t.laptop AS merk_laptop,
                COALESCE(STRING_AGG(DISTINCT jp.jenis_kerusakan, ', '), '') AS kerusakan,
                t.alamat,
                COALESCE(STRING_AGG(DISTINCT k.nama_komponen, ', '), '') AS komponen,
                COALESCE(SUM(DISTINCT dt.biaya), 0) + COALESCE(SUM(DISTINCT dc.harga * dc.jumlah), 0) AS total_harga,
                t.status_transaksi
            FROM 
                transaksi t
            LEFT JOIN 
                detail_transaksi dt ON t.id_transaksi = dt.id_transaksi
            LEFT JOIN 
                jasa_perbaikan jp ON dt.id_jasa_perbaikan = jp.id_jasa_perbaikan
            LEFT JOIN 
                detail_komponen dc ON t.id_transaksi = dc.id_transaksi
            LEFT JOIN 
                komponen k ON dc.id_komponen = k.id_komponen
            GROUP BY 
                t.id_transaksi, t.tanggal, t.nama_pelanggan, t.laptop, t.alamat, t.status_transaksi
            ORDER BY 
                t.tanggal DESC";

            return DatabaseWrapper.queryExecutor(query);
        }
    }
}
