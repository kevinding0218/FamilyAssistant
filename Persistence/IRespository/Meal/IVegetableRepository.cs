using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyAssistant.Core.Models.Meal;
using FamilyAssistant.Core.Query;

namespace FamilyAssistant.Persistence.IRespository.Meal
{
    public interface IVegetableRepository
    {
        Task<bool> IsDuplicateVegetable(string name);
        Task<QueryResult<Vegetable>> GetVegetables(VegetableQuery filter);
         Task<Vegetable> GetVegetable(int id);
         void AddVegetable(Vegetable newVegetable);
         void Remove(Vegetable existedVegetable);
         Task<int> GetNumberOfEntreesWithVege (int vegeId);
    }
}