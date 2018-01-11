using AutoMapper;
using FamilyAssistant.Controllers.Resource.Meal;
using FamilyAssistant.Core.Models.Meal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FamilyAssistant.Controllers.Resource.Shared;
using FamilyAssistant.Controllers.Resource.Query;
using FamilyAssistant.Core.Query;

namespace FamilyAssistant.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to API Resource/View Model
            CreateMap(typeof(QueryResult<>), typeof(QueryResultResource<>));
            this.CreateMap<Vegetable, SaveVegetableResource>()
                .ForMember
                (svr => svr.keyValuePairInfo, opt => opt.MapFrom(v => new KeyValuePairResource {Id = v.Id,Name = v.Name}));
            this.CreateMap<Vegetable, GridVegetableResource>()
                .ForMember(gvr => gvr.NumberOfEntreeIncluded, opt => opt.Ignore())
                .ForMember
                (gvr => gvr.keyValuePairInfo, opt => opt.MapFrom(v => new KeyValuePairResource {Id = v.Id,Name = v.Name}));

            // API Resource/View Model to Domain
            this.CreateMap<VegetableQueryResource, VegetableQuery>();
            this.CreateMap<SaveVegetableResource, Vegetable>()
                    .ForMember(v => v.Id, opt => opt.Ignore())
                    .ForMember(v => v.Name, opt => opt.MapFrom(svr => svr.keyValuePairInfo.Name));
        }
    }
}
