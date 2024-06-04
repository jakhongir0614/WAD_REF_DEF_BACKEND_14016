using Microsoft.EntityFrameworkCore;
using WAD_REFDEF_BACKEND_14016.Data;
using WAD_REFDEF_BACKEND_14016.Models;

namespace WAD_REFDEF_BACKEND_14016.Repository
{
    public class UserRepository : IUserRespositiory
    {
        private readonly KeyUseDbContext _context;
        public UserRepository(KeyUseDbContext dbContext)
        {
            _context = dbContext;
        }
        public async Task CreateUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUser(int id)
        {
            var keys = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (keys != null)
            {
                _context.Users.Remove(keys);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<User>> GetAllUser()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        public async Task<User> GetSingleUser(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(k => k.Id == id);
        }

        public async Task UpdateUser(User user,int id)
        {
            var userToUpdate = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);

            // Check if the user exists
            if (userToUpdate == null)
            {
                throw new ArgumentException("User not found with the specified ID.");
            }

            userToUpdate.Name = user.Name; 
            userToUpdate.Email = user.Email;  

            // Save changes to the database
            _context.Users.Update(userToUpdate);
            await _context.SaveChangesAsync();
        }
    }
}
