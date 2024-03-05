using MediatR;
using Microsoft.EntityFrameworkCore;
using SkateCompScoreboard.Core.Entities;
using SkateCompScoreboard.Persistence.Data;

namespace SkateCompScoreboard.Application.Competitors.Features
{
    public class List
    {
        public class Query : IRequest<List<Competitor>> { }

        public class Handler : IRequestHandler<Query, List<Competitor>>
        {
            private DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public Task<List<Competitor>> Handle(Query request, CancellationToken cancellationToken)
            {
                return _context.Competitors.ToListAsync(cancellationToken);
            }
        }
    }
}
