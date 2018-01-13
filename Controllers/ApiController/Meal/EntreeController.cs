using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using FamilyAssistant.Controllers.Resource.Meal;
using FamilyAssistant.Persistence.IRespository;
using FamilyAssistant.Persistence.IRespository.Meal;
using FamilyAssistant.Persistence.IRespository.User;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace FamilyAssistant.Controllers.ApiController.Meal
{
    [EnableCors("SiteCorsPolicy")]
    [Route ("/api/entree")]
    public class EntreeController : Controller
    {
        private readonly IMapper _mapper;
        public readonly IEntreeRepository _entreeRepository;
        private readonly IUnitOfWork _uow;
        private readonly IUserRepository _userRepository;

        public EntreeController (IMapper mapper, IEntreeRepository entreeRepository, IUserRepository userRepository, IUnitOfWork uow) {
            this._userRepository = userRepository;
            this._uow = uow;
            this._entreeRepository = entreeRepository;
            this._mapper = mapper;
        }

        #region READ LIST OF OBJECTS
        [Route("/api/entree/withVege/{vegeId}")]
        [HttpGet]
         public async Task<IEnumerable<EntreeInfoResource>> GetEntressWithVegeId (int vegeId) {
             var entrees = await this._entreeRepository.GetEntreeInfoWithVegeId(vegeId);

            return entrees;
         }

        [Route("/api/entree/withMeat/{meatId}")]
        [HttpGet]
         public async Task<IEnumerable<EntreeInfoResource>> GetEntressWithMeatId (int meatId) {
             var entrees = await this._entreeRepository.GetEntreeInfoWithMeatId(meatId);

            return entrees;
         }
         #endregion
    }
}