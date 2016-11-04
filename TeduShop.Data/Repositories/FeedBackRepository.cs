using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IFeedBackRepository : IRepository<Feedback>
    {
    }

    public class FeedBackRepository : RepositoryBase<Feedback>, IFeedBackRepository
    {
        public FeedBackRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}