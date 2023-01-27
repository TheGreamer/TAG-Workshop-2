using KnowledgeWorkshop.WebAPI.Core.Entity.Concrete;
using System.Text.Json.Serialization;

namespace KnowledgeWorkshop.WebAPI.Entity.Concrete
{
    public class Category : CoreEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }

        [JsonIgnore]
        public List<Product> Products { get; set; }
    }
}