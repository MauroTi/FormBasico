using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace FormBasico.Services
{
    public class MySqlConnectionService
    {
        private readonly IConfiguration _configuration;

        public MySqlConnectionService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public MySqlConnection GetConnection()
        {
            string connStr = _configuration.GetConnectionString("DefaultConnection");
            return new MySqlConnection(connStr);
        }

        public string TestarConexao()
        {
            try
            {
                using var conn = GetConnection();
                conn.Open();
                return "Conexão bem-sucedida!";
            }
            catch (Exception ex)
            {
                return $"Erro de conexão: {ex.Message}";
            }
        }
    }
}