using MediatR;
using Microsoft.EntityFrameworkCore;
using SkateCompScoreboard.Core.Entities;
using SkateCompScoreboard.Persistence.Data;

namespace SkateCompScoreboard.Application.RoundCompetitors.Features
{
    public class List
    {
        public class Query : IRequest<List<RoundCompetitor>> { }

        public class Handler : IRequestHandler<Query, List<RoundCompetitor>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public Task<List<RoundCompetitor>> Handle(Query request, CancellationToken cancellationToken)
            {
                return _context.RoundCompetitors.ToListAsync(cancellationToken);
            }
        }
    }
}
