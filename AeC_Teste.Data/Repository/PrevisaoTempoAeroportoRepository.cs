using AeC_Teste.Business.Entidades;
using AeC_Teste.Business.Interfaces.Repository;
using AeC_Teste.Data.Data;

namespace AeC_Teste.Data.Repository
{
    public class PrevisaoTempoAeroportoRepository : Repository<PrevisaoTempoAeroporto>, IPrevisaoTempoAeroportoRepository
    {
        public PrevisaoTempoAeroportoRepository(AecDbContext context) : base(context)
        {
        }
    }
}
