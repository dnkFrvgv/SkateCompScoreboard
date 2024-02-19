using SkateCompScoreboard.Core.Enums;

namespace SkateCompScoreboard.Core.Entities
{
    public class Trick
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public TrickDifficulty Difficulty { get; set; }
    }
}
