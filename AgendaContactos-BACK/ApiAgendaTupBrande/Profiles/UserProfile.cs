using ApiAgendaTupBrande.Entities;
using ApiAgendaTupBrande.Models.Dtos;
using AutoMapper;

namespace ApiAgendaTupBrande.Profiles
{
    public class UserProfile: Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
        }
    }
}
