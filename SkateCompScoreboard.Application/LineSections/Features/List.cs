using MediatR;
using Microsoft.EntityFrameworkCore;
using SkateCompScoreboard.Core.Entities;
using SkateCompScoreboard.Persistence.Data;

namespace SkateCompScoreboard.Application.LineSections.Features
{
    public class List
    {
        public class Query : IRequest<List<LineSection>> { }

        public class Handler : IRequestHandler<Query, List<LineSection>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }
            public Task<List<LineSection>> Handle(Query request, CancellationToken cancellationToken)
            {
                return _context.LineSections.ToListAsync(cancellationToken);
            }
        }
    }
}
