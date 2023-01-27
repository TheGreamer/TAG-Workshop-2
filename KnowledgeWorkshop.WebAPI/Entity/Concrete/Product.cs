using KnowledgeWorkshop.WebAPI.Core.Entity.Concrete;
using System.Text.Json.Serialization;

namespace KnowledgeWorkshop.WebAPI.Entity.Concrete
{
    public class Product : CoreEntity
    {
        [JsonPropertyOrder(1)]
        public Guid CategoryId { get; set; }

        [JsonPropertyOrder(2)]
        public string Name { get; set; }

        [JsonPropertyOrder(3)]
        public string? Description { get; set; }

        [JsonPropertyOrder(4)]
        public string Brand { get; set; }

        [JsonPropertyOrder(5)]
        public double Price { get; set; }

        [JsonIgnore]
        public Category Category { get; set; }
    }
}