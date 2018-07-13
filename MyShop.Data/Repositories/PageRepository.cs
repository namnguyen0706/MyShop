using MyShop.Data.Infrastructure;
using MyShop.Model.Models;

namespace MyShop.Data.Repository
{
    public interface IPageRepository
    {
    }

    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}