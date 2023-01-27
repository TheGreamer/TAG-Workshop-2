using KnowledgeWorkshop.WebAPI.Core.Entity.Concrete;
using System.Linq.Expressions;

namespace KnowledgeWorkshop.WebAPI.Core.DataAccess.Abstract
{
    public interface IEfRepository<TEntity> where TEntity : CoreEntity, new()
    {
        Task<List<TEntity>> GetList(Expression<Func<TEntity, bool>>? filter = null);
    }
}