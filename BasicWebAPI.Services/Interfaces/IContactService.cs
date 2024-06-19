using BasicWebAPI.DTOs.ContactDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebAPI.Services.Interfaces
{
    public interface IContactService
    {
        Task<List<ContactDTO>> GetAllContactsAsync();
        Task<ContactDTO> GetContactByIdAsync(int id);
        Task<int> CreateContactAsync(CreateContactDTO createContactDTO);
        Task EditContactAsync(EditContactDTO editContactDTO);
        Task DeleteContactAsync(int id);
        Task<List<ContactWithCompanyAndCountryDTO>> FilterContacts(int? countryId, int? companyId);
    }
}
