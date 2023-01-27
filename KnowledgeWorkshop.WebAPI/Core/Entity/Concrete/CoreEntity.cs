using System.Text.Json.Serialization;

namespace KnowledgeWorkshop.WebAPI.Core.Entity.Concrete
{
    public class CoreEntity
    {
        [JsonPropertyOrder(0)]
        public Guid Id { get; set; }
    }
}