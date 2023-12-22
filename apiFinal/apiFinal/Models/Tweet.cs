using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace finalServeur.Models
{
    public class Tweet
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Text { get; set; }
        public int Score { get; set; }

        [JsonIgnore]
        public virtual User? User { get; set; }

        public virtual Picture? Picture { get; set; }

        // Propriétés pour une relation optionnelle One-To-Many avec un Tweet parent (Si ce tweet est une réponse à un autre tweet)
        [JsonIgnore]
        public virtual Tweet? AnswerTo { get; set; }
        [JsonIgnore]
        public virtual List<Tweet>? Answers { get; set; }
    }
}
