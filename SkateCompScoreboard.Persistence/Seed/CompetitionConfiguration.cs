using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SkateCompScoreboard.Core.Entities;

namespace SkateCompScoreboard.Persistence.Seed;

public class CompetitionConfiguration : IEntityTypeConfiguration<Competition>
{
    public void Configure(EntityTypeBuilder<Competition> builder)
    {
        builder.HasData
        (
            new Competition
            {
                Id = Guid.NewGuid(),
                Name = "SLS Sidney 2024: Women's Tournament",
                OpenningDate = new DateTime(2024, 03, 12),
                Category = 'f',
                Modality = Core.Enums.Modality.STREET,
                Status = Core.Enums.CompetitionStatus.READY_TO_START,
                NumberOfRounds = 3,
            },
            new Competition
            {
                Id = Guid.NewGuid(),
                Name = "XGames Japan 2024: Man's Vert",
                OpenningDate = new DateTime(2024, 05, 20),
                Category = 'm',
                Modality = Core.Enums.Modality.VERT,
                Status = Core.Enums.CompetitionStatus.READY_TO_START,
                NumberOfRounds = 2,
            },
            new Competition
            {
                Id = Guid.NewGuid(),
                Name = "XGames Japan 2024: Women's Park",
                OpenningDate = new DateTime(2024, 05, 22),
                Category = 'f',
                Modality = Core.Enums.Modality.PARK,
                Status = Core.Enums.CompetitionStatus.READY_TO_START,
                NumberOfRounds = 3,
            }
        );
    }
}
