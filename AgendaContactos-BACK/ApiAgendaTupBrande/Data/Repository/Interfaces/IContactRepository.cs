using ApiAgendaTupBrande.Entities;
using Azure;

namespace ApiAgendaTupBrande.Data.Repository.Interfaces
{
    public interface IContactRepository
    {
        Task<List<Contact>> GetListContacts();
        Task<Contact> GetContactById(int id);
        Task DeleteContact(Contact contact);
        Task<Contact> AddContact(Contact contact);
        Task UpdateContact(Contact contact);   
        //Task AddFavorite(int id, JsonPatchDocument favoriteDTO);
    }
}
