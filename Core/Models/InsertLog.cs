using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyAssistant.Core.Models
{
    public class InsertLog
    {
        public DateTime AddedOn { get; set; }

        public User AddedBy { get; set; }
    }
}
