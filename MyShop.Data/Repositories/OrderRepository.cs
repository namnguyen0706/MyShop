using MyShop.Data.Infrastructure;
using MyShop.Model.Models;

namespace MyShop.Data.Repository
{
    public interface IOrderRepository
    {
    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}