using BasicWebAPI.DTOs.CompanyDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebAPI.Services.Interfaces
{
    public interface ICompanyService
    {
        Task<List<CompanyDTO>> GetAllCompaniesAsync();
        Task<CompanyDTO> GetCompanyByIdAsync(int id);
        Task<int> CreateCompanyAsync(CreateCompanyDTO createCompanyDTO);
        Task EditCompanyAsync(EditCompanyDTO editMovieDTO);
        Task DeleteCompanyAsync(int id);
    }
}
