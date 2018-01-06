using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FamilyAssistant.Persistence.IRespository.User;

namespace FamilyAssistant.Persistence.Repository.User {
    public class UserRepository : IUserRepository
    {
        private readonly FaDbContext _context;
        public UserRepository (FaDbContext context) {
            this._context = context;

        }
        public async Task<bool> IsExistedUser (int userId) {
            return await _context.Users.AnyAsync (u => u.UserID == userId);
        }

        public async Task<string> GetUserFullName (int userId) {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserID == userId);

            if (user != null) {
                return string.Format("{0} {1}", user.FirstName, user.LastName);
            } else {
                return "User Not Found";
            }
        }
    }
}