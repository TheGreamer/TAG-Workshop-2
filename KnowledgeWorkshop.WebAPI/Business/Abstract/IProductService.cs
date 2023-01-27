using KnowledgeWorkshop.WebAPI.Core.Business.Abstract;
using KnowledgeWorkshop.WebAPI.DataAccess.Abstract;
using KnowledgeWorkshop.WebAPI.Entity.Concrete;

namespace KnowledgeWorkshop.WebAPI.Business.Abstract
{
    public interface IProductService : ICoreService<Product, IProductDal>
    {
    }
}