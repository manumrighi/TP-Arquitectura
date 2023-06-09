using ApiAgendaTupBrande.Entities;
using ApiAgendaTupBrande.Models.Dtos;

namespace ApiAgendaTupBrande.Data.Repository.Interfaces
{
    public interface IUserRepository
    {
        public User? ValidateUser(AuthenticationRequestBody authRequestBody);
        Task<List<User>> GetListUsers();
        Task<User> GetUserById(int Id);
        Task DeleteUser(User user);
        Task<User> AddUser(User user);
        Task UpdateUser(User user);
    }
}
 