using BasicWebAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebAPI.Mappers
{
    public static class ContactMappers
    {
        public static ContactDTO ToContactDTO(this Contact contact)
        {
            return new ContactDTO()
            {
                Id = contact.Id,
                ContactName = contact.ContactName,
                CompanyId = contact.CompanyId,
                CountryId = contact.CountryId
            };
        }

        public static Contact ToContact(this CreateContactDTO createContactDTO)
        {
            return new Contact()
            {
                CountryId = createContactDTO.CountryId,
                CompanyId = createContactDTO.CompanyId,
                ContactName = createContactDTO.ContactName
            };
        }
    }
}
