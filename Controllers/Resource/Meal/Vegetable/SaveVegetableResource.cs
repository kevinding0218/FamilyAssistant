using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FamilyAssistant.Controllers.Resource.Shared;

namespace FamilyAssistant.Controllers.Resource.Meal
{
    public class SaveVegetableResource
    {
        public KeyValuePairResource vegetableKeyValuePairInfo { get; set; }
        public DateTime AddedOn { get; set; }
        
        public DateTime? LastUpdatedByOn { get; set; }
        public int AddedByUserId { get; set; }

        public int? LastUpdatedByUserId { get; set; }  
    }
}
