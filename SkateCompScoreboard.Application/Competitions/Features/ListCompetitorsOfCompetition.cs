using MediatR;
using Microsoft.EntityFrameworkCore;
using SkateCompScoreboard.Core.Entities;
using SkateCompScoreboard.Persistence.Data;

namespace SkateCompScoreboard.Application.Competitions.Features
{
    public class ListCompetitorsOfCompetition
    {
        public class Query : IRequest<List<RoundCompetitor>>
        {
            public Guid CompetitionId { get; set; }
        }

        public class Handler : IRequestHandler<Query, List<RoundCompetitor>>
        {
            private DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public Task<List<RoundCompetitor>> Handle(Query request, CancellationToken cancellationToken)
            {
                return _context.RoundCompetitors.Where(
                    x => x.Round.CompetitionId == request.CompetitionId &&
                    x.Round.RoundOrder == 1)
                    .Include(x => x.Competitor)
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
