using KnowledgeWorkshop.WebAPI.Business.Abstract;
using KnowledgeWorkshop.WebAPI.Core.Business.Concrete;
using KnowledgeWorkshop.WebAPI.DataAccess.Abstract;
using KnowledgeWorkshop.WebAPI.Entity.Concrete;

namespace KnowledgeWorkshop.WebAPI.Business.Concrete
{
    public class ProductService : CoreService<Product, IProductDal>, IProductService
    {
        public ProductService(IProductDal productDal) : base(productDal)
        {
        }
    }
}