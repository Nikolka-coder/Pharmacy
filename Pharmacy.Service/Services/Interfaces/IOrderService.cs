using Pharmacy.DAL.Models.DTO;
using Pharmacy.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pharmacy.Services.Interfaces
{
    public interface IOrderService
    {
        Task<List<OrderIndex>> GetAllOrdersAsync();
        Task<Order> GetOrderByIdAsync(int orderId);
        Task AddOrderAsync(OrderCreate orderCreateViewModel);
        Task EditOrderAsync(Order order);
        Task DeleteOrderAsync(int orderId);
        //Task<List<OrderIndex>> GetAllOrdersAsync();
    }
}
