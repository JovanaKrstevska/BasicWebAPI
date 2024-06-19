using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebAPI.Domain.Entities
{
    public class Country : BaseEntity
    {
        public string CountryName { get; set; } = string.Empty;
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
