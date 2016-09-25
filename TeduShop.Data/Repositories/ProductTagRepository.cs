using TeduShop.Data.Infrastructure;

namespace TeduShop.Data.Repositories
{
    public interface IProductTagRepository : IRepository<ProductTag> { }

    public class ProductTag : RepositoryBase<ProductTag>, IProductTagRepository
    {
        public ProductTag(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}