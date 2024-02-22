using SkateCompScoreboard.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace SkateCompScoreboard.Application.Competitions.Dtos
{
    public class CompetitionRequestDto
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public Guid AddressId { get; set; }
        [RegularExpression("(?: m | M | f | F)$", ErrorMessage = "Gender must be 'M' or 'F'.")]
        public char Category { get; set; }
        [Required]
        public Modality Modality { get; set; }
        public CompetitionStatus Status { get; set; }
    }

}
