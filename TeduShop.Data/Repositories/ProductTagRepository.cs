using TeduShop.Common.Infrastructure;
using TeduShop.Data.Infrastructure;

namespace TeduShop.Data.Repositories
{
    public interface IProductTagRepository { }

    public class ProductTag : RepositoryBase<ProductTag>, IProductTagRepository
    {
        public ProductTag(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}