using BasicWebAPI.Domain.Entities;
using BasicWebAPI.DTOs.CountryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebAPI.Mappers
{
    public static class CountryMappers
    {
        public static CountryDTO ToCountryDTO(this Country country)
        {
            return new CountryDTO()
            {
                Id = country.Id,
                CompanyId = country.CompanyId,
                CountryName = country.CountryName
            };
        }

        public static Country ToCountry(this CreateCountryDTO createCountryDTO)
        {
            return new Country()
            {
                CountryName = createCountryDTO.CountryName,
                CompanyId = createCountryDTO.CompanyId
            };
        }
    }
}
