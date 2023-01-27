using KnowledgeWorkshop.WebAPI.Core.DataAccess.Abstract;
using KnowledgeWorkshop.WebAPI.Core.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace KnowledgeWorkshop.WebAPI.Core.DataAccess.Concrete
{
    public class EfRepository<TEntity, TContext> : IEfRepository<TEntity>
        where TEntity : CoreEntity, new()
        where TContext : DbContext, new()
    {
        public async Task<List<TEntity>> GetList(Expression<Func<TEntity, bool>>? filter = null)
        {
            using (TContext context = new())
            {
                return filter == null
                    ? await context.Set<TEntity>().ToListAsync()
                    : await context.Set<TEntity>().Where(filter).ToListAsync();
            }
        }
    }
}