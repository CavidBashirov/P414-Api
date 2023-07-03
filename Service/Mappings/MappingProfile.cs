using AutoMapper;
using Domain.Entities;
using Service.DTOs.Country;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CountryCreateDto, Country>();
            CreateMap<Country, CountryDto>().ForMember(dest => dest.CountryName,opt => opt.MapFrom(src => src.Name));
            CreateMap<CountryUpdateDto, Country>();
        }
    }
}
