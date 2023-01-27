using KnowledgeWorkshop.WebAPI.Core.DataAccess.Concrete;
using KnowledgeWorkshop.WebAPI.DataAccess.Abstract;
using KnowledgeWorkshop.WebAPI.DataAccess.Concrete.Contexts;
using KnowledgeWorkshop.WebAPI.Entity.Concrete;

namespace KnowledgeWorkshop.WebAPI.DataAccess.Concrete.Layers
{
    public class ProductDal : EfRepository<Product, EfContext>, IProductDal
    {
    }
}