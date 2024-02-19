namespace SkateCompScoreboard.Core.Entities
{
    public class Score
    {
        public Guid Id { get; set; }
        public float FinalScore { get => FinalScore; set { if (IsScoreValid(value)) FinalScore = value; } }
        public Guid CompetitorId { get; set; }
        public RoundCompetitor Competitor { get; set; }
        public Guid TrickId { get; set; }
        public Trick Trick { get; set; }
        public Guid SectionId { get; set; }
        public Section Section { get; set; }

        public static bool IsScoreValid(float score)
        {
            return score <= 10.0 && score >= 0;
        }
    }
}
