using BasicWebAPI.DataAccess.Repositories.Interfaces;
using BasicWebAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebAPI.DataAccess.Repositories.Implementations
{
    public class ContactRepository : IRepository<Contact>
    {
        public Task<int> CreateAsync(Contact entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Contact>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Contact> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Contact> UpdateAsync(Contact entity)
        {
            throw new NotImplementedException();
        }
    }
}
