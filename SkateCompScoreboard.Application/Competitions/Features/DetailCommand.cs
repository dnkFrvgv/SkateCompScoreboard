using MediatR;
using Microsoft.EntityFrameworkCore;
using SkateCompScoreboard.Core.Entities;
using SkateCompScoreboard.Persistence.Data;

namespace SkateCompScoreboard.Application.Competitions.Features
{
    public class DetailCommand
    {
        public class Query : IRequest<Competition>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Competition>
        {
            public DataContext _context { get; }

            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<Competition> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Competitions.Include(x=>x.Rounds).FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            }
        }
    }
}
