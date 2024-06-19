﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebAPI.DTOs.ContactDTOs
{
    public class ContactDTO
    {
        public int Id { get; set; }
        public string ContactName { get; set; } = string.Empty;
        public string CompanyName { get; set; }
        public int CompanyId { get; set; }
        public string CountryName { get; set; }
        public int CountryId { get; set; }
    }
}
