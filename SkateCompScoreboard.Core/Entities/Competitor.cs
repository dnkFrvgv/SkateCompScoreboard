namespace SkateCompScoreboard.Core.Entities
{
    public class Competitor
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Place Origin { get; set; }
        public char Gender {  get; set; }
    }
}
