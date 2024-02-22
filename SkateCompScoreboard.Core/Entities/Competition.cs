using SkateCompScoreboard.Core.Enums;
using System.Text.Json.Serialization;

namespace SkateCompScoreboard.Core.Entities
{
    public class Competition
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDateTime { get; set; }
        public Address Place { get; set; }
        public char Category { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Modality Modality { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public CompetitionStatus Status { get; set; } = CompetitionStatus.READY_TO_START;
        public ICollection<Round> Rounds { get; } = new List<Round>();
    }
}
