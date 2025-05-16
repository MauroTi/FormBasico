using FormBasico.Models;
using MySql.Data.MySqlClient;

namespace FormBasico.Dao
{
    public class OsDao
    {
        private readonly MySqlConnection _connection;

        public OsDao(MySqlConnection connection)
        {
            _connection = connection;
        }

        public void Inserir(OsModel osModel)
        {
            string sql = "INSERT INTO rat (numeroOS) VALUES (@NumeroOS)";
            using var cmd = new MySqlCommand(sql, _connection);
            cmd.Parameters.AddWithValue("@NumeroOS", osModel.NumeroOS);

            _connection.Open();
            cmd.ExecuteNonQuery();
            _connection.Close();
        }
    }
}