using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebAPI.DTOs.CountryDTOs
{
    public class CountryDTO
    {
        public int Id { get; set; }
        public string CountryName { get; set; } = string.Empty;
        public int CompanyId { get; set; }
    }
}
