using System.Text.Json.Serialization;

namespace SnackisAPI.Models
{
    public class Category
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("userid")]
        public string? UserId { get; set; }
    }
}
