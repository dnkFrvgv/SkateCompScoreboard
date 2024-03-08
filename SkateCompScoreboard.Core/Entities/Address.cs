namespace SkateCompScoreboard.Core.Entities
{
    public class Address
    {
        public Guid Id { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Acronym { get; set; }

        public override string ToString()
        {
            return Acronym.ToUpper();
        }
    }
}