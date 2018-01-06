using System.Threading.Tasks;

namespace FamilyAssistant.Persistence.IRespository.User
{
    public interface IUserRepository
    {
         Task<bool> IsExistedUser (int userId);
         Task<string> GetUserFullName (int userId);
    }
}