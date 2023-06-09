using ApiAgendaTupBrande.Data.Repository.Interfaces;
using ApiAgendaTupBrande.Entities;
using Azure;
using Microsoft.EntityFrameworkCore;

namespace ApiAgendaTupBrande.Data.Repository.Implementation
{
    public class ContactRepository: IContactRepository
    {
        private readonly AplicationDbContext _context;

        public ContactRepository(AplicationDbContext context)
        {
            _context = context;                
        }

        public async Task<List<Contact>> GetListContacts()
        {
            return await _context.Contacts.ToListAsync();
        }

        public async Task<Contact> GetContactById(int id)
        {
            return await _context.Contacts.FindAsync(id);
        }

        public async Task DeleteContact(Contact contact)
        {
            //Removemos el objeto 
            _context.Contacts.Remove(contact);
            //Guardamos los cambios
            await _context.SaveChangesAsync();
        }

        public async Task<Contact> AddContact(Contact contact)
        {
            _context.Add(contact);
            await _context.SaveChangesAsync();
            return contact;
        }

        public async Task UpdateContact(Contact contact)
        {
            _context.Update(contact);
            await _context.SaveChangesAsync();
        }

        //public async Task AddFavorite(int id, JsonPatchDocument favoriteDTO)
        //{
        //    var contact = await _context.Contacts.FindAsync(id);
        //    if (contact != null)
        //    {
        //        favoriteDTO.App  

        //    }
        //}


        //public async Task AddFavorite(Contact contact)
        //{
        //    var contactItem = await _context.Contacts.FirstOrDefaultAsync(x => x.Id == contact.Id);

        //    if(contactItem != null)
        //    {
        //        contactItem.Favorite = true;
        //    }

        //    await _context.SaveChangesAsync();
        //}
    }  
}
