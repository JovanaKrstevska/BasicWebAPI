using BasicWebAPI.DataAccess.Repositories.Interfaces;
using BasicWebAPI.Domain.Entities;
using BasicWebAPI.DTOs.CompanyDTOs;
using BasicWebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebAPI.Services.Implementations
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository _companyRepository)
        {
            this._companyRepository = _companyRepository;
        }
        public async Task<List<CompanyDTO>> GetAllCompaniesAsync()
        {
            List<Company> companyDb = await _companyRepository.GetAllAsync();

            if (companyDb == null)
                throw new Exception("Companies not found.Contact the support team");

            return companyDb.Select(x => x.ToCompanyDTO()).ToList();
        }
        public async Task<CompanyDTO> GetCompanyByIdAsync(int id)
        {
            Company companyDb = await _companyRepository.GetByIdAsync(id);

            if (companyDb == null)
                throw new Exception("Company not found.Contact the support team");

            return companyDb.ToCompanyDTO();
        }
        public async Task<int> CreateCompanyAsync(CreateCompanyDTO createCompanyDTO)
        {
            Company companyDb = createCompanyDTO.ToCompany();
            await _companyRepository.CreateAsync(companyDb);

            return companyDb.Id;
        }
        public async Task EditCompanyAsync(EditCompanyDTO editCompanyDTO)
        {
            Company companyDb = await _companyRepository.GetByIdAsync(editCompanyDTO.Id);

            if (companyDb == null)
                throw new Exception("The company can not be found.Contact the support team!");

            companyDb.CompanyName = editCompanyDTO.CompanyName;

            await _companyRepository.UpdateAsync(companyDb);
        }
        public async Task DeleteCompanyAsync(int id)
        {
            await _companyRepository.DeleteAsync(id);
        }
    }
}
