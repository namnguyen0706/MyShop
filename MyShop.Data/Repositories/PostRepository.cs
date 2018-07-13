using MyShop.Data.Infrastructure;
using MyShop.Model.Models;

namespace MyShop.Data.Repository
{
    public interface IPostRepository
    {
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}