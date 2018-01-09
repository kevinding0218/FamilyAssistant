using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FamilyAssistant.Controllers.Resource.Meal;
using FamilyAssistant.Core.Models.Meal;
using FamilyAssistant.Persistence;
using FamilyAssistant.Persistence.IRespository;
using FamilyAssistant.Persistence.IRespository.Meal;
using FamilyAssistant.Persistence.IRespository.User;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FamilyAssistant.Controllers.ApiController {
    [EnableCors("SiteCorsPolicy")]
    [Route ("/api/vegetable")]
    public class VegetableController : Controller {
        private readonly IMapper _mapper;
        public readonly IVegetableRepository _vegeRepository;
        private readonly IUnitOfWork _uow;
        private readonly IUserRepository _userRepository;

        public VegetableController (IMapper mapper, IVegetableRepository vegeRepository, IUserRepository userRepository, IUnitOfWork uow) {
            this._userRepository = userRepository;
            this._uow = uow;
            this._vegeRepository = vegeRepository;
            this._mapper = mapper;
        }

        [HttpGet]
         public async Task<IEnumerable<GridVegetableResource>> GetVegetables () {
             var vegetables = await _vegeRepository.GetVegetables();

             var gridVegetables = _mapper.Map<List<Vegetable>, List<GridVegetableResource>>(vegetables);

             foreach(var gridVege in gridVegetables) {
                 var AddedByUserId = gridVege.AddedByUserId;
                 var VegeId = gridVege.keyValuePairInfo.Id;

                 gridVege.AddedByUserName = await _userRepository.GetUserFullName(AddedByUserId);
                 gridVege.NumberOfEntreeIncluded = await _vegeRepository.GetNumberOfEntreesWithVege(VegeId);
             }

             return gridVegetables;     
         }

        [HttpGet ("{id}")]
        public async Task<IActionResult> GetVegetable (int id) {
            var isExistedVegetable = await _vegeRepository.GetVegetable (id);
            if (isExistedVegetable == null)
                return NotFound ();

            // Convert from Domain Model to View Model
            var result = _mapper.Map<Vegetable, SaveVegetableResource> (isExistedVegetable);

            // Return view Model
            return Ok (result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateVegetable ([FromBody] SaveVegetableResource newVegetableResource) {
            if (!ModelState.IsValid)
                return BadRequest (ModelState);

            if (!await _userRepository.IsExistedUser(newVegetableResource.AddedByUserId)) {
                ModelState.AddModelError ("NonExistedUser", "User Not Found!");
                return BadRequest (ModelState);
            }

            if (await _vegeRepository.IsDuplicateVegetable (newVegetableResource.keyValuePairInfo.Name)) {
                ModelState.AddModelError ("DuplicateVegetable", newVegetableResource.keyValuePairInfo.Name + " already existed!");
                return BadRequest (ModelState);
            }

            // Convert from View Model to Domain Model
            var newVegetable = _mapper.Map<SaveVegetableResource, Vegetable> (newVegetableResource);
            newVegetable.AddedOn = DateTime.Now;

            // Insert into database by using Domain Model
            _vegeRepository.AddVegetable (newVegetable);
            await _uow.CompleteAsync ();

            newVegetable = await _vegeRepository.GetVegetable (newVegetable.Id);
            // Convert from Domain Model to View Model
            var result = _mapper.Map<Vegetable, SaveVegetableResource> (newVegetable);

            // Return view Model
            return Ok (result);
        }

        [HttpPut ("{id}")] //api/vegetable/id
        public async Task<IActionResult> UpdateVegetable (int id, [FromBody] SaveVegetableResource SaveVegetableResource) {
            if (!ModelState.IsValid)
                return BadRequest (ModelState);

            var isExistedVegetable = await _vegeRepository.GetVegetable (id);
            if (isExistedVegetable == null)
                return NotFound ();

            if (await _vegeRepository.IsDuplicateVegetable (SaveVegetableResource.keyValuePairInfo.Name)) {
                ModelState.AddModelError ("DuplicateVegetable", SaveVegetableResource.keyValuePairInfo.Name + " already existed!");
                return BadRequest (ModelState);
            }

            // Convert from View Model to Domain Model
            _mapper.Map<SaveVegetableResource, Vegetable> (SaveVegetableResource, isExistedVegetable);
            isExistedVegetable.LastUpdatedByOn = DateTime.Now;

            // Insert into database by using Domain Model
            await _uow.CompleteAsync ();

            // Fetch complete object from database
            isExistedVegetable = await _vegeRepository.GetVegetable(isExistedVegetable.Id);
            // Convert from Domain Model to View Model
            var result = _mapper.Map<Vegetable, SaveVegetableResource> (isExistedVegetable);

            // Return view Model
            return Ok (result);
        }

        [HttpDelete ("{id}")] //api/vegetable/id
        public async Task<IActionResult> DeleteVegetable (int id) {
            var existedVegetable = await _vegeRepository.GetVegetable (id);
            if (existedVegetable == null)
                return NotFound ();

            _vegeRepository.Remove (existedVegetable);
            await _uow.CompleteAsync ();

            return Ok (id);
        }
    }
}