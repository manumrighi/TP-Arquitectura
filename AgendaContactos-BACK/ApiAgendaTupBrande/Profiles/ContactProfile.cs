using ApiAgendaTupBrande.Entities;
using ApiAgendaTupBrande.Models.Dtos;
using AutoMapper;

namespace ApiAgendaTupBrande.Profiles
{
    public class ContactProfile: Profile
    { 
        public ContactProfile()
        {
            CreateMap<Contact, ContactDTO>();
            CreateMap<ContactDTO, Contact>();
        }
    }
}
