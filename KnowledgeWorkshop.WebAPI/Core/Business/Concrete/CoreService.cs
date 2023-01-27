using KnowledgeWorkshop.WebAPI.Core.Business.Abstract;
using KnowledgeWorkshop.WebAPI.Core.DataAccess.Abstract;
using KnowledgeWorkshop.WebAPI.Core.Entity.Concrete;
using System.Linq.Expressions;

namespace KnowledgeWorkshop.WebAPI.Core.Business.Concrete
{
    public class CoreService<TEntity, TDal> : ICoreService<TEntity, TDal>
        where TEntity : CoreEntity, new()
        where TDal : IEfRepository<TEntity>
    {
        private readonly TDal _dal;

        public CoreService(TDal dal)
        {
            _dal = dal;
        }

        public virtual async Task<List<TEntity>> GetAll()
        {
            return await _dal.GetList();
        }

        public virtual async Task<List<TEntity>> GetAllByFilter(Expression<Func<TEntity, bool>> filter)
        {
            return await _dal.GetList(filter);
        }
    }
}