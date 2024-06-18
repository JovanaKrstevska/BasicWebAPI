using BasicWebAPI.DataAccess.Repositories.Interfaces;
using BasicWebAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebAPI.DataAccess.Repositories.Implementations
{
    public class CompanyRepository : IRepository<Company>
    {
        public Task<int> CreateAsync(Company entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Company>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Company> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Company> UpdateAsync(Company entity)
        {
            throw new NotImplementedException();
        }
    }
}
