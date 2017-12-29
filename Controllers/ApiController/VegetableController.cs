using AutoMapper;
using FamilyAssistant.Controllers.Resource;
using FamilyAssistant.Core.Models;
using FamilyAssistant.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyAssistant.Controllers.ApiController
{
    public class VegetableController : Controller
    {
        private readonly FaDbContext _context;
        private readonly IMapper _mapper;

        public VegetableController(FaDbContext context, IMapper mapper)
        {
          this._context = context;
          this._mapper = mapper;
        }

        [HttpGet("/api/vegetables")]
        public async Task<IEnumerable<VegetableResource>> GetVeges()
        {
            var vegetables = await _context.Vegetables.Include(v => v.AddedBy).ToListAsync();
        
            return _mapper.Map<List<Vegetable>, List<VegetableResource>>(vegetables);
        }
  }
}
