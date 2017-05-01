using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Npgsql;

namespace PgStat
{
    class PgWorker: IDisposable
    {
        string Hostname { get; set; }
        string Username { get; set; }
        string Port { get; set; }
        string Password { get; set; }
        string Database { get; set; }

        private readonly NpgsqlConnection _conn;
        public bool IsConnected { get; }

        public PgWorker(string hostname, string port, string username, string password, string database="postgres")
        {
            Hostname = hostname;
            Port = port;
            Username = username;
            Password = password;
            Database = database;
            IsConnected = false;

            try
            {
                _conn = new NpgsqlConnection($"Host=\"{Hostname}\";Port=\"{Port}\";Username=\"{Username}\";Password=\"{Password}\";" +
                                             $"Database=\"{Database}\";CommandTimeout=0;Pooling=false");
                _conn.Open();
                IsConnected = true;
            }
            catch (Exception e)
            {
                IsConnected = false;
                MessageBox.Show("Ошибка подключения: " + e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string GetQuery(string command)
        {
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = _conn;
                cmd.CommandText = command;
                StringBuilder result = new StringBuilder();
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.AppendLine(reader.GetString(0));
                    }
                    return result.ToString();
                }
            }
        }

        public void GetData(string command, DataGridView dgv)
        {
            DataSet ds = new DataSet();
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = _conn;
                cmd.CommandText = command;
                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                    dgv.DataSource = ds.Tables[0];
                }
            }
        }

        public void Dispose()
        {
            if (IsConnected)
            {
                _conn.Close();
            }
        }
    }
}
