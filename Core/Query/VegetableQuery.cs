using FamilyAssistant.Extensions;

namespace FamilyAssistant.Core.Query
{
    public class VegetableQuery : IQueryObject
    {
        public int? VegetableId { get; set; }

        public string SortBy { get; set; }
        public bool IsSortAscending { get; set; }
        public int Page { get; set; }
        public byte PageSize { get; set; }
    }
}