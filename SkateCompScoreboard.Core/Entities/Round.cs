using SkateCompScoreboard.Core.Enums;
using System.Text.Json.Serialization;

namespace SkateCompScoreboard.Core.Entities
{
    public class Round
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public TypeRound Type { get; set; }
        public int NumberOfCompetitors { get; set; }
        public int NumberOfSections { get; set; }
        public int RoundOrder { get; set; }
        public RoundStatus Status { get; set; }
        
        public Guid CompetitionId { get; set; }
        [JsonIgnore]
        public Competition Competition { get; set; }
        public ICollection<Section> Sections { get; } = new List<Section>();
        public ICollection<RoundCompetitor> Competitors { get; } = new List<RoundCompetitor>();

        public bool CanAddNewSection()
        {
            return Sections.Count < NumberOfSections;
        }

        public bool CanAddNewCompetitor() 
        {
            return Competitors.Count < NumberOfCompetitors;
        }
    }
}
