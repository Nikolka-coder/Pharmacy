﻿using System;
using AutoMapper;
using Pharmacy.DAL.Models.DTO;
using Pharmacy.Mappings.Resolvers;
using Pharmacy.Models;
using Pharmacy.Models.DTO;

namespace Pharmacy.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, OrderIndex>()
                .ForMember(d => d.MedicineName, opts => opts.MapFrom<MedicineNameResolver>())
                .ForMember(d => d.WithPrescription, opts => opts.MapFrom<WithPrescriptionResolver>())
                .ForMember(d => d.Order, opts => opts.MapFrom(s => s));
            CreateMap<OrderCreate, Order>()
                .ForMember(d => d.Date, opts => opts.MapFrom(s => DateTime.UtcNow))
                .ForMember(d => d.OrderCost, opts => opts.MapFrom<OrderCostResolver>());
            CreateMap<Medicine, MedicineName>();
            CreateMap<Prescription, PrescriptionNumber>()
                .ForMember(d => d.Number, opts => opts.MapFrom(s => s.PrescriptionNumber));
        }
    }
}