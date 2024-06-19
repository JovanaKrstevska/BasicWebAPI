using BasicWebAPI.DataAccess.Repositories.Interfaces;
using BasicWebAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebAPI.DataAccess.Repositories.Implementations
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly BasicWebApiDbContext _dbContext;

        public CompanyRepository(BasicWebApiDbContext _dbContext)
        {
            this._dbContext = _dbContext;
        }
        public async Task<List<Company>> GetAllAsync()
        {
            return await _dbContext.Companies.ToListAsync();
        }
        public async Task<Company> GetByIdAsync(int id)
        {
            return await _dbContext.Companies.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<int> CreateAsync(Company entity)
        {
            await _dbContext.Companies.AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity.Id;
        }
        public async Task<Company> UpdateAsync(Company entity)
        {
            _dbContext.Companies.Update(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }
        public async Task DeleteAsync(int id)
        {
            Company companyDb = await _dbContext.Companies.SingleOrDefaultAsync(x => x.Id == id);

            if (companyDb == null)
                throw new Exception($"Company with id:{id} not found!");

            _dbContext.Companies.Remove(companyDb);
            await _dbContext.SaveChangesAsync();
        }
    }
}
