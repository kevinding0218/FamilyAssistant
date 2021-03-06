using System.Collections.Generic;

namespace FamilyAssistant.Core.Query
{
    public class QueryResult<T>
    {
        public int TotalItems { get; set; }
        public IEnumerable<T> Items { get; set; }
        public IEnumerable<T> TotalItemList { get; set;}
    }
}