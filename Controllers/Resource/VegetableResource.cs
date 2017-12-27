using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyAssistant.Controllers.Resource
{
    public class VegetableResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AddedBy { get; set; }
        public DateTime AddedOn { get; set; }
    }
}
