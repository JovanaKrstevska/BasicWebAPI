using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebAPI.Domain.Entities
{
    public class Company : BaseEntity
    {
        public string CompanyName { get; set; } = string.Empty;
        public List<Country> Countries { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
