using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmacy.DAL.Models.DTO
{
    public class OrderCreate
    {
        public int? PrescriptionId { get; set; }
        public int MedicineId { get; set; }
        public int Amount { get; set; }
    }
}
