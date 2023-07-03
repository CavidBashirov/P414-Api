using Service.DTOs.Country;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface ICountryService
    {
        Task CreateAsync(CountryCreateDto model);
        Task<List<CountryDto>> GetAllAsync();
        Task UpdateAsync(int? id, CountryUpdateDto model);
    }
}
