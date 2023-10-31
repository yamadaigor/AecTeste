using AeC_Teste.Business.Entidades;
using AeC_Teste.Business.Interfaces.Repository;
using AeC_Teste.Data.Data;

namespace AeC_Teste.Data.Repository
{
    public class LogErroRepository : Repository<LogErro>, ILogErroRepository
    {
        public LogErroRepository(AecDbContext context) : base(context)
        {
        }
    }
}
