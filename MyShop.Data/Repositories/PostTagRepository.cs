using MyShop.Data.Infrastructure;
using MyShop.Model.Models;

namespace MyShop.Data.Repository
{
    public interface IPostTagRepository
    {
    }

    public class PostTagRepository : RepositoryBase<PostTag>, IPostTagRepository
    {
        public PostTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}