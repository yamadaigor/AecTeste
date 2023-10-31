using AeC_Teste.Business.Entidades;
using System.Linq.Expressions;

namespace AeC_Teste.API.Interfaces.Repository
{
    public interface IRepository<T> : IDisposable where T : EntidadeBase
    {
        void Incluir(T entidade);
        void Atualizar(T entidade);
        void Excluir(Guid id);
        T ObterPorId(Guid id);
        List<T> ObterTodosRegistros();
        int SaveChanges();
        IEnumerable<T> ObterRegistros(Expression<Func<T, bool>> predicate);
    }
}
