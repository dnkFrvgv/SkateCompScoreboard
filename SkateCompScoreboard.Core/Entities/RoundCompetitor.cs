namespace SkateCompScoreboard.Core.Entities
{
    public class RoundCompetitor
    {
        public Round Round { get; set; }
        public Guid RoundId { get; set; }
        public Competitor Competitor { get; set; }
        public Guid CompetitorId { get; set; }
        public ICollection<Score> Scores { get; } = new List<Score>();
        public int Order { get; set; }
        public int PodiumOrder { get; set; }
    }
}
