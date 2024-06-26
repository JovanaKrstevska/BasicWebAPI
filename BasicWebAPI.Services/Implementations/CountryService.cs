﻿using BasicWebAPI.DataAccess.Repositories.Interfaces;
using BasicWebAPI.Domain.Entities;
using BasicWebAPI.DTOs.CountryDTOs;
using BasicWebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebAPI.Services.Implementations
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;

        public CountryService(ICountryRepository _countryRepository)
        {
            _countryRepository = _countryRepository;
        }

        public async Task<List<CountryDTO>> GetAllCountriesAsync()
        {
            List<Country> countryDb = await _countryRepository.GetAllAsync();

            if (countryDb == null)
                throw new Exception("Countries not found.Contact the support team");

            return countryDb.Select(x => x.ToCountryDTO()).ToList();
        }
        public async Task<CountryDTO> GetCountryByIdAsync(int id)
        {
            Country countryDb = await _countryRepository.GetByIdAsync(id);

            if (countryDb == null)
                throw new Exception("Country not found.Contact the support team");

            return countryDb.ToCountryDTO();
        }
        public async Task<int> CreateCountryAsync(CreateCountryDTO createCountryDTO)
        {
            Country countryDb = createCountryDTO.ToCountry();
            await _countryRepository.CreateAsync(countryDb);

            return countryDb.Id;
        }
        public async Task EditCountryAsync(EditCountryDTO editCountryDTO)
        {
            Country countryDb = await _countryRepository.GetByIdAsync(editCountryDTO.Id);

            if (countryDb == null)
                throw new Exception("The country can not be found.Contact the support team!");

            countryDb.CountryName = editCountryDTO.CountryName;
            countryDb.CompanyId = editCountryDTO.CompanyId;

            await _countryRepository.UpdateAsync(countryDb);
        }
        public async Task DeleteCountryAsync(int id)
        {
            await _countryRepository.DeleteAsync(id);
        }
    }
}
