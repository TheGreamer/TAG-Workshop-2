using KnowledgeWorkshop.WebAPI.Core.DataAccess.Abstract;
using KnowledgeWorkshop.WebAPI.Entity.Concrete;

namespace KnowledgeWorkshop.WebAPI.DataAccess.Abstract
{
    public interface IProductDal : IEfRepository<Product>
    {
    }
}