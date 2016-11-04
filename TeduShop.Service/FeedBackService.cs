using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IFeedBackService
    {
        Feedback Create(Feedback feedBack);

        void Save();
    }

    public class FeedBackService : IFeedBackService
    {
        private IFeedBackRepository _feedBackRepositoty;
        private IUnitOfWork _unitOfWork;

        public FeedBackService(IFeedBackRepository feedBackRepository, IUnitOfWork unitOfWork)
        {
            _feedBackRepositoty = feedBackRepository;
            _unitOfWork = unitOfWork;
        }

        public Feedback Create(Feedback feedBack)
        {
            return _feedBackRepositoty.Add(feedBack);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}