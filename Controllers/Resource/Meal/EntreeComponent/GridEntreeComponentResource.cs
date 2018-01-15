using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FamilyAssistant.Controllers.Resource.Shared;

namespace FamilyAssistant.Controllers.Resource.Meal
{
    public class GridEntreeComponentResource
    {
        public KeyValuePairResource keyValuePairInfo { get; set; }
        public String AddedOn { get; set; }
        
        public String LastUpdatedByOn { get; set; }

        public int AddedByUserId { get; set; }
        public string AddedByUserName { get; set; }  
        
        public int NumberOfEntreeIncluded { get; set; }
        public IEnumerable<EntreeInfoResource> EntreesIncluded { get; set; }
        public string Note { get; set; }
    }
}
