using MediatR;
using Microsoft.EntityFrameworkCore;
using SkateCompScoreboard.Core.Entities;
using SkateCompScoreboard.Persistence.Data;

namespace SkateCompScoreboard.Application.Competitions.Features
{
    public class ListRoundsOfCompetition
    {
      
        public class Query : IRequest<List<Round>> 
        {
            public Guid CompetitionId {  get; set; }
        }

        public class Handler : IRequestHandler<Query, List<Round>>
        {
            private DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<List<Round>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Rounds.
                    Where(x=>x.CompetitionId == request.CompetitionId)
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
