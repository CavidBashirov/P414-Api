using AutoMapper;
using Domain.Entities;
using Repository.Repositories.Interfaces;
using Service.DTOs.Country;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepo;
        private readonly IMapper _mapper;

        public CountryService(ICountryRepository countryRepo,IMapper mapper)
        {
            _countryRepo = countryRepo;  
            _mapper = mapper;
        }

        public async Task CreateAsync(CountryCreateDto model)
        {
            await _countryRepo.CreateAsync(_mapper.Map<Country>(model));
        }

        public async Task<List<CountryDto>> GetAllAsync()
        {
            return _mapper.Map<List<CountryDto>>(await _countryRepo.FindAllAsync());
        }

        public async Task UpdateAsync(int? id, CountryUpdateDto model)
        {
            Country country = await _countryRepo.FindAsync(id);

            _mapper.Map(model, country);

            await _countryRepo.UpdateAsync(country);
        }
    }
}
