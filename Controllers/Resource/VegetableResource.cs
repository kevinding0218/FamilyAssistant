using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FamilyAssistant.Core.Models;

namespace FamilyAssistant.Controllers.Resource
{
    public class VegetableResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime AddedOn { get; set; }
        public User AddedBy { get; set; }
    }
}
