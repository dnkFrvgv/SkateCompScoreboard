using MediatR;
using Microsoft.EntityFrameworkCore;
using SkateCompScoreboard.Core.Entities;
using SkateCompScoreboard.Persistence.Data;

namespace SkateCompScoreboard.Application.Competitions.Features
{
    public class ListCommand
    {
        public class Query : IRequest<List<Competition>> { }

        public class Handler : IRequestHandler<Query, List<Competition>>
        {
            public DataContext _context { get; }

            public Handler(DataContext context)
            {
                _context = context;
            }


            public async Task<List<Competition>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Competitions.ToListAsync(cancellationToken);
            }
        }
    }
}
