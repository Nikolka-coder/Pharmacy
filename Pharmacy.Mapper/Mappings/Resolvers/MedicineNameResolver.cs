using AutoMapper;
using Pharmacy.DAL.Models.DTO;
using Pharmacy.Models;
using Pharmacy.Services.Interfaces;

namespace Pharmacy.Mappings.Resolvers
{
    public class MedicineNameResolver : IValueResolver<Order, OrderIndex, string>
    {
        private readonly IMedicineService _medicineService;

        public MedicineNameResolver(IMedicineService medicineService) => _medicineService = medicineService;

        public string Resolve(Order order, OrderIndex orderIndexViewModel, string destMember,
            ResolutionContext context) =>
            _medicineService.GetMedicineByIdAsync(order.MedicineId).Result.Name;
    }
}
