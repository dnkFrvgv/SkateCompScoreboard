using MediatR;
using Microsoft.EntityFrameworkCore;
using SkateCompScoreboard.Core.Entities;
using SkateCompScoreboard.Persistence.Data;

namespace SkateCompScoreboard.Application.Tricks.Features
{
    public class List
    {
        public class Query : IRequest<List<Trick>> { }

        public class Handler : IRequestHandler<Query, List<Trick>>
        {
            private DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public Task<List<Trick>> Handle(Query request, CancellationToken cancellationToken)
            {
                return _context.Tricks.ToListAsync(cancellationToken);
            }
        }
    }
}
