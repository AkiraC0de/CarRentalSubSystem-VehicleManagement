using MySqlConnector;
using DotNetEnv;


namespace VehicleManagementSystem.Data {

    public static class MySQLConnectionContext {

        public static MySqlConnection Create() {
            string host = Env.GetString("DB_HOST");
            string port = Env.GetString("DB_PORT");
            string db = Env.GetString("DB_NAME");
            string user = Env.GetString("DB_USER");
            string pass = Env.GetString("DB_PASSWORD");

            string connStr = $"Server={host};Port={port};Database={db};User={user};Password={pass};SslMode=Required;";

            return new MySqlConnection(connStr);
        }

    }
}
