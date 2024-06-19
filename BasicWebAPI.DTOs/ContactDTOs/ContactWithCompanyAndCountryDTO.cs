using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebAPI.DTOs.ContactDTOs
{
    public class ContactWithCompanyAndCountryDTO
    {
        public string ContactName { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string CountryName { get; set; } = string.Empty;
    }
}
