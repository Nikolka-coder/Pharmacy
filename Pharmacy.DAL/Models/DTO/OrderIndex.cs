using Pharmacy.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmacy.DAL.Models.DTO
{
    public class OrderIndex
    {
        public Order Order { get; set; }
        public string MedicineName { get; set; }
        public bool WithPrescription { get; set; }
    }
}
