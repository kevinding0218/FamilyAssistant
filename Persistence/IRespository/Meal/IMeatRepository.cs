using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyAssistant.Core.Models.Meal;

namespace FamilyAssistant.Persistence.IRespository.Meal
{
    public interface IMeatRepository
    {
        Task<bool> IsDuplicateMeat (string name);
        Task<IEnumerable<Meat>> GetMeats ();
        Task<Meat> GetMeat (int id);
        void AddMeat (Meat newMeat);
        void Remove (Meat existedMeat);
         Task<int> GetNumberOfEntreesWithMeat (int meatId);
    }
}