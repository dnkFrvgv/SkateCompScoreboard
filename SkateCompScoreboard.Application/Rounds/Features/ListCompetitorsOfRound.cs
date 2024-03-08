using MediatR;
using Microsoft.EntityFrameworkCore;
using SkateCompScoreboard.Core.Entities;
using SkateCompScoreboard.Persistence.Data;

namespace SkateCompScoreboard.Application.Rounds.Features
{
    public class ListCompetitorsOfRound
    {
        public class Query : IRequest<List<RoundCompetitor>> 
        {
            public Guid RoundId {  get; set; }
        }

        public class Handler : IRequestHandler<Query, List<RoundCompetitor>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public Task<List<RoundCompetitor>> Handle(Query request, CancellationToken cancellationToken)
            {
                return _context.RoundCompetitors
                    .Where(x=>x.RoundId == request.RoundId)
                    .Include(x => x.Competitor)
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
