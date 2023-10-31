using AeC_Teste.Business.Entidades;
using AeC_Teste.Business.Interfaces.Repository;
using AeC_Teste.Data.Data;

namespace AeC_Teste.Data.Repository
{
    public class PrevisaoTempoCidadeRepository : Repository<PrevisaoTempoCidade>, IPrevisaoTempoCidadeRepository
    {
        public PrevisaoTempoCidadeRepository(AecDbContext context) : base(context)
        {
        }

        public void AddListaPrevisaoTempoCidade(List<PrevisaoTempoCidade> listaPrevisaoTempoCidade)
        {
            _dbSet.AddRange(listaPrevisaoTempoCidade);
            SaveChanges();
        }
    }
}
