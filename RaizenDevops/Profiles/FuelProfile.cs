using AutoMapper;
using RaizenDevops.Core.Entities;
using RaizenDevops.Models;

namespace RaizenDevops.API.Profiles
{
    public class FuelProfile : Profile
    {
        public FuelProfile()
        {
            CreateMap<Fuel, FuelViewModel>();
        }
    }
}
