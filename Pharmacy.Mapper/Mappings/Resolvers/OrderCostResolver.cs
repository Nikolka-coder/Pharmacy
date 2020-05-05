using AutoMapper;
using Pharmacy.DAL.Models.DTO;
using Pharmacy.Models;
using Pharmacy.Services.Interfaces;

namespace Pharmacy.Mappings.Resolvers
{
    public class OrderCostResolver : IValueResolver<OrderCreate, Order, double>
    {
        private readonly IMedicineService _medicineService;

        public OrderCostResolver(IMedicineService medicineService) => _medicineService = medicineService;

        public double Resolve(OrderCreate orderCreateViewModel, Order order, double destMember, ResolutionContext context) =>
            _medicineService.GetMedicineByIdAsync(order.MedicineId).Result.Price * order.Amount;
    }
}
