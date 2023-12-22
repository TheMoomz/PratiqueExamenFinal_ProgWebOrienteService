using System.Text.Json.Serialization;

namespace finalServeur.Models
{
    public class Picture
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string MimeType { get; set; }

        [JsonIgnore]
        public virtual Tweet Tweet { get; set; }

        [JsonIgnore]
        public int TweetId { get; set; }
    }
}
