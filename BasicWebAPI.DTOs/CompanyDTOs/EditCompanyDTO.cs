﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebAPI.DTOs.CompanyDTOs
{
    public class EditCompanyDTO
    {
        public int Id { get; set; }
        public string CompanyName { get; set; } = string.Empty;
    }
}
