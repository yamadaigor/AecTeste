using AeC_Teste.API.Interfaces.Repository;
using AeC_Teste.Business.Entidades;

namespace AeC_Teste.Business.Interfaces.Repository
{
    public interface IPrevisaoTempoCidadeRepository : IRepository<PrevisaoTempoCidade>
    {
        void AddListaPrevisaoTempoCidade(List<PrevisaoTempoCidade> listaPrevisaoTempoCidade);
    }
}
