using BasicWebAPI.DataAccess.Repositories.Interfaces;
using BasicWebAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebAPI.DataAccess.Repositories.Implementations
{
    public class CountryRepository : IRepository<Country>
    {
        public Task<int> CreateAsync(Country entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Country>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Country> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Country> UpdateAsync(Country entity)
        {
            throw new NotImplementedException();
        }
    }
}
