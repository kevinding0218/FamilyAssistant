using System.Collections.Generic;
using FamilyAssistant.CustomAttribute;

namespace FamilyAssistant.Controllers.Resource.Meal
{
    public class EntreeInfoResource
    {
        public int EntreeId { get; set; }
        public string EntreeName { get; set; }
        public int VegetableCount { get; set; }
        public int MeatCount { get; set; }
        public string StapleFood { get; set; }
        public string Note { get; set; }
        [IngoreReadToListAttribute]
        public IEnumerable<EntreeDetailResource> EntreeDetailList { get; set; }

        public EntreeInfoResource()
        {
            EntreeDetailList = new List<EntreeDetailResource>();
        }
    }
}