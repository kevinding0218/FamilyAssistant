using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FamilyAssistant.Persistence.Repository.User {
    public class UserRepository {
        private readonly FaDbContext _context;
        public UserRepository (FaDbContext context) {
            this._context = context;

        }
        public async Task<bool> IsExistedUser (int userId) {
            return await _context.Users.AnyAsync (u => u.UserID == userId);
        }
    }
}