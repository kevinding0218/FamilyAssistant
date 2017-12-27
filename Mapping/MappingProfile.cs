using AutoMapper;
using FamilyAssistant.Controllers.Resource;
using FamilyAssistant.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyAssistant.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<Vegetable, VegetableResource>();
        }
    }
}
