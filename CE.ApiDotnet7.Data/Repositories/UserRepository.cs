using CE.ApiDotnet7.Domain.Entities;
using CE.ApiDotnet7.Domain.Interfaces;
using CE.ApiDotnet7.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CE.ApiDotnet7.Infra.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly CeContext _db;

        public UserRepository(CeContext db)
        {
            _db = db;
        }

        public async Task<User> CreateAsync(User User)
        {
            _db.Add(User);
            await _db.SaveChangesAsync();
            return User;
        }

        public async Task DeleteAsync(User User)
        {
            _db.Remove(User);
            await _db.SaveChangesAsync();
        }

        public async Task EditAsync(User User)
        {
            _db.Update(User);
            await _db.SaveChangesAsync();
        }

        public async Task<ICollection<User>> GetAllAsync()
        {
            return await _db.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _db.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            return await _db.Users.FirstOrDefaultAsync(x => x.Email == email);
        }
    }
}
