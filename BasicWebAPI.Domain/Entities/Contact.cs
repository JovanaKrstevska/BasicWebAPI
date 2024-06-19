using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebAPI.Domain.Entities
{
    public class Contact : BaseEntity
    {
        public string ContactName { get; set; } = string.Empty;
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
