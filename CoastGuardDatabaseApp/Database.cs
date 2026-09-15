using MySql.Data.MySqlClient;
using System;

namespace CoastGuardDatabaseApp
{
    public static class Database
    {
        public static MySqlConnection GetConnection()
        {
            string password = Environment.GetEnvironmentVariable(
                "CG_DB_PASSWORD", EnvironmentVariableTarget.User);

            if (string.IsNullOrEmpty(password))
                throw new InvalidOperationException(
                    "Set the Windows user variable CG_DB_PASSWORD to your application database user's password.");

            uint port;
            if (!uint.TryParse(GetSetting("CG_DB_PORT", "3306"), out port) ||
                port == 0 || port > 65535)
                throw new InvalidOperationException("CG_DB_PORT must be a number from 1 to 65535.");

            var builder = new MySqlConnectionStringBuilder
            {
                Server = GetSetting("CG_DB_HOST", "127.0.0.1"),
                Port = port,
                Database = GetSetting("CG_DB_NAME", "coast_guard_assets"),
                UserID = GetSetting("CG_DB_USER", "cg_app"),
                Password = password,
                ConnectionTimeout = 5,
                DefaultCommandTimeout = 15,
                PersistSecurityInfo = false
            };
            return new MySqlConnection(builder.ConnectionString);
        }

        private static string GetSetting(string name, string fallback)
        {
            string value = Environment.GetEnvironmentVariable(name, EnvironmentVariableTarget.User);
            return string.IsNullOrWhiteSpace(value) ? fallback : value.Trim();
        }
    }
}
