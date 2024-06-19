using BasicWebAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebAPI.Mappers
{
    public static class CompanyMappers
    {
        public static CompanyDTO ToCompanyDTO(this Company company)
        {
            return new CompanyDTO()
            {
                Id = company.Id,
                CompanyName = company.CompanyName
            };
        }

        public static Company ToCompany(this CreateCompanyDTO createCompanyDTO)
        {
            return new Company()
            {
                CompanyName = createCompanyDTO.CompanyName
            };
        }
    }
}
