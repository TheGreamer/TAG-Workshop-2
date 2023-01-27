using KnowledgeWorkshop.WebAPI.Core.DataAccess.Abstract;
using KnowledgeWorkshop.WebAPI.Core.Entity.Concrete;
using System.Linq.Expressions;

namespace KnowledgeWorkshop.WebAPI.Core.Business.Abstract
{
    public interface ICoreService<TEntity, TDal>
        where TEntity : CoreEntity, new()
        where TDal : IEfRepository<TEntity>
    {
        Task<List<TEntity>> GetAll();
        Task<List<TEntity>> GetAllByFilter(Expression<Func<TEntity, bool>> filter);
    }
}