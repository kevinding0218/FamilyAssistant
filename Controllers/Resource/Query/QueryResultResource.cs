using System.Collections.Generic;

namespace FamilyAssistant.Controllers.Resource.Query
{
    public class QueryResultResource<T>
    {
        public int TotalItems { get; set; }
        public IEnumerable<T> Items { get; set; }
        public IEnumerable<T> TotalItemList { get; set;}
    }
}