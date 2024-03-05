using MediatR;
using Microsoft.EntityFrameworkCore;
using SkateCompScoreboard.Core.Entities;
using SkateCompScoreboard.Persistence.Data;

namespace SkateCompScoreboard.Application.Scores.Features
{
    public class List
    {
        public class Query : IRequest<List<Score>> { }

        public class Handler : IRequestHandler<Query, List<Score>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }
            public Task<List<Score>> Handle(Query request, CancellationToken cancellationToken)
            {
                return _context.Scores.ToListAsync(cancellationToken);
            }
        }
    }
}
