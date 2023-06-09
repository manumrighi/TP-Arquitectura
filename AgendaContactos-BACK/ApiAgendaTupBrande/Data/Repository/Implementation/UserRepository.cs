using ApiAgendaTupBrande.Data.Repository.Interfaces;
using ApiAgendaTupBrande.Entities;
using ApiAgendaTupBrande.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace ApiAgendaTupBrande.Data.Repository.Implementation
{
    public class UserRepository: IUserRepository
    {
        private readonly AplicationDbContext _context;

        public UserRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetListUsers()
        { 
            return await _context.Users.ToListAsync();
        }

        public User? ValidateUser(AuthenticationRequestBody authRequestBody)
        {
            return _context.Users.FirstOrDefault(p => p.UserName == authRequestBody.UserName && p.Password == authRequestBody.Password);
        }

        public async Task<User> GetUserById(int Id)
        {
            return await _context.Users.FindAsync(Id);
        }

        public async Task DeleteUser(User user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User> AddUser(User user)
        {
            _context.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task UpdateUser(User user)
        {
            _context.Update(user);
            await _context.SaveChangesAsync();
        }

    }
}
