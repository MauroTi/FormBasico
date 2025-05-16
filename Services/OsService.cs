using FormBasico.Dao;
using FormBasico.Models;

namespace FormBasico.Services
{
    public class OsService
    {
        private readonly MySqlConnectionService _connService;

        public OsService(MySqlConnectionService connService)
        {
            _connService = connService;
        }

        public void CadastrarOs(OsModel osModel)
        {
            using var conn = _connService.GetConnection();
            var dao = new OsDao(conn);
            dao.Inserir(osModel);
        }
    }
}