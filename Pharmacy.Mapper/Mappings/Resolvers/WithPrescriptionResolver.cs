using AutoMapper;
using Pharmacy.DAL.Models.DTO;
using Pharmacy.Models;
using Pharmacy.Services.Interfaces;

namespace Pharmacy.Mappings.Resolvers
{
    public class WithPrescriptionResolver : IValueResolver<Order, OrderIndex, bool>
    {
        private readonly IMedicineService _medicineService;

        public WithPrescriptionResolver(IMedicineService medicineService) => _medicineService = medicineService;

        public bool Resolve(Order order, OrderIndex orderIndexViewModel, bool destMember, ResolutionContext context) =>
            _medicineService.GetMedicineByIdAsync(order.MedicineId).Result.WithPrescription;
    }
}
