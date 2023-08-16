using Models;

namespace DAL.Services
{
    internal interface IOrderService
    {
        public Task<string> PostOrder(Order order);
        public Task<object> GetOrders(int userId);
    }
}
