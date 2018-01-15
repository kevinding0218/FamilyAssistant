using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyAssistant.Core.Models.Shared
{
    public class TransLog
    {
        public int AddedByUserId { get; set; }  
        public DateTime AddedOn { get; set; }
        
        public int? LastUpdatedByUserId { get; set; }  
        public DateTime? LastUpdatedByOn { get; set; }
    }
}
