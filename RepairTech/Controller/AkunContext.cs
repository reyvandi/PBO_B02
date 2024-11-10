using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using PROJECT_PBO.Controller;
using PROJECT_PBO.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PROJECT_PBO.Controller
{
    internal class AkunContext : DatabaseWrapper
    {
        private static string table = "akun";

        public static DataTable All()
        {
            string query = @"
        SELECT 
            m.id,
            m.username,
            m.password,
            m.role,
            m.email
            From akun m";

            DataTable dataMahasiswa = queryExecutor(query);
            return dataMahasiswa;
        }

        public void RegisterAkun(M_Akun newAkun)
        {
            string query = $"INSERT INTO {table} (username, password, role, email) VALUES(@username, @password, 'pelanggan', @email)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", newAkun.username),
                new NpgsqlParameter("@password",newAkun.password),
                new NpgsqlParameter("@email", newAkun.email)
            };

            commandExecutor(query, parameters);
        }
        public static bool IsEmailExist(string email)
        {
            string query = "SELECT COUNT(*) FROM akun WHERE Email = @email";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@email", email)
            };
            int count = DatabaseWrapper.executeScalar(query, parameters);
            return count > 0;

        }
        
        public static bool IsUsernameExist(string username)
        {
            string query = "SELECT COUNT(*) FROM akun WHERE username = @username";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", username)
            };
            int count = DatabaseWrapper.executeScalar(query, parameters);
            return count > 0;

        }

        public DataTable GetAkunByUsernamePassword(string username, string password)
        {
            string query = $"SELECT id_akun, username, password, role, email FROM {table} WHERE username = @username AND password = @password";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@username", username),
            new NpgsqlParameter("@password", password)
        };
            return queryExecutor(query, parameters);
        }
    }
}
