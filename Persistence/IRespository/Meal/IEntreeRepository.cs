using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyAssistant.Controllers.Resource.Meal;
using FamilyAssistant.Controllers.Resource.Shared;

namespace FamilyAssistant.Persistence.IRespository.Meal
{
    public interface IEntreeRepository
    {
         Task<IEnumerable<EntreeInfoResource>> GetEntreeInfoWithVegeId (int VegeId);
         Task<IEnumerable<EntreeInfoResource>> GetEntreeInfoWithMeatId (int MeatId);
         Task<IEnumerable<EntreeInfoResource>> GetEntreeDetails ();
         Task<IEnumerable<EntreeDetailResource>> GetEntreeDetailWithEntreeId (int EntreeId);
    }
}