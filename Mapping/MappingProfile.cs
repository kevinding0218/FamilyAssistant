using AutoMapper;
using FamilyAssistant.Controllers.Resource.Meal;
using FamilyAssistant.Core.Models.Meal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FamilyAssistant.Controllers.Resource.Shared;

namespace FamilyAssistant.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to API Resource/View Model
            this.CreateMap<Vegetable, SaveVegetableResource>()
                .ForMember
                (svr => svr.vegetableKeyValuePairInfo, opt => opt.MapFrom(v => new KeyValuePairResource {Id = v.Id,Name = v.Name}));
            this.CreateMap<Vegetable, GridVegetableResource>()
                .ForMember(svr => svr.NumberOfEntreeIncluded, opt => opt.Ignore())
                .ForMember
                (svr => svr.vegetableKeyValuePairInfo, opt => opt.MapFrom(v => new KeyValuePairResource {Id = v.Id,Name = v.Name}));

            // API Resource/View Model to Domain
            this.CreateMap<SaveVegetableResource, Vegetable>()
                    .ForMember(v => v.Id, opt => opt.Ignore())
                    .ForMember(v => v.Name, opt => opt.MapFrom(svr => svr.vegetableKeyValuePairInfo.Name));
        }
    }
}
