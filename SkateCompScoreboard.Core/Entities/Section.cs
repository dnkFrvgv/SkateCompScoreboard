namespace SkateCompScoreboard.Core.Entities
{
    public abstract class Section
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Round Round { get; set; }
        public Guid RoundId { get; set; }

        public int SectionOrder { get; set; }
        public ICollection<Score> Scores { get; } = new List<Score>();

        public Competitor GetNextCompetitor() 
        {
            throw new NotImplementedException();            
        }

        public bool CanAddNewScore()
        {
            return Scores.Count < Round.NumberOfCompetitors;
        }

        public void GetPodium()
        {
            throw new NotImplementedException();
        }
    }
}
