using System.Threading.Tasks;

namespace FamilyAssistant.Persistence.IRespository
{
    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}