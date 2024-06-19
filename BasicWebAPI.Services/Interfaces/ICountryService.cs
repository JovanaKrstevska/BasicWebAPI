using BasicWebAPI.DTOs.CountryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebAPI.Services.Interfaces
{
    public interface ICountryService
    {
        Task<List<CountryDTO>> GetAllCountriesAsync();
        Task<CountryDTO> GetCountryByIdAsync(int id);
        Task<int> CreateCountryAsync(CreateCountryDTO createCountryDTO);
        Task EditCountryAsync(EditCountryDTO editCountryDTO);
        Task DeleteCountryAsync(int id);
    }
}
