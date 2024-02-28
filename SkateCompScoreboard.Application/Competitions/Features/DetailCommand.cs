using MediatR;
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
                return await _context.Competitions.FindAsync(request.Id, cancellationToken);
            }
        }
    }
}
