﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_PBO.Controller
{
    internal class DatabaseWrapper
    {
        // Properti credential database dan koneksinya
        private static readonly string DB_HOST = "localhost";
        private static readonly string DB_DATABASE = "RepairTech";
        private static readonly string DB_USERNAME = "postgres";
        private static readonly string DB_PASSWORD = "Aditya03";
        private static readonly string DB_PORT = "5432";

        private static NpgsqlConnection connection;
        private static NpgsqlCommand command;

        // Method open dan close Koneksi
        public static void openConnection()
        {
            connection = new NpgsqlConnection($"Host={DB_HOST};Username={DB_USERNAME};Password={DB_PASSWORD};Database={DB_DATABASE};Port={DB_PORT}");
            connection.Open();
            command = new NpgsqlCommand();
            command.Connection = connection;
        }

        public static void closeConnection()
        {
            connection.Close();
            command.Parameters.Clear();
        }

        // Method untuk eksekusi query dan mengembalikan DataTable
        public static DataTable queryExecutor(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                openConnection();
                DataTable dataTable = new DataTable();
                command.CommandText = query;
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                    command.Prepare();
                }
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                closeConnection();
                return dataTable;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        // Method untuk eksekusi query tanpa hasil pengembalian (Non-Query)
        public static void commandExecutor(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                openConnection();
                command.CommandText = query;
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                command.Prepare();
                command.ExecuteNonQuery();
                command.Parameters.Clear();
                closeConnection();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        // Method untuk eksekusi query dan mengembalikan satu nilai (ExecuteScalar)
        public static int executeScalar(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                openConnection();
                command.CommandText = query;
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                command.Prepare();
                int result = Convert.ToInt32(command.ExecuteScalar());
                command.Parameters.Clear();
                closeConnection();
                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
