using SkateCompScoreboard.Core.Enums;

namespace SkateCompScoreboard.Core.Entities
{
    public class Competition
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDateTime { get; set; }
        public Place Place { get; set; }
        public char Category { get; set; }
        public Modality Modality { get; set; }
        public CompetitionStatus Status { get; set; } = CompetitionStatus.READY_TO_START;
        public ICollection<Round> Rounds { get; } = new List<Round>();
    }
}
