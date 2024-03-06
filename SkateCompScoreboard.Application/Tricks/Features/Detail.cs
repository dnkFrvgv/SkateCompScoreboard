using MediatR;
using SkateCompScoreboard.Core.Entities;
using SkateCompScoreboard.Persistence.Data;

namespace SkateCompScoreboard.Application.Tricks.Features
{
    public class Detail
    {
        public class Query : IRequest<Trick>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Trick>
        {
            public DataContext _context { get; }

            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<Trick> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Tricks.FindAsync(request.Id, cancellationToken);
            }
        }
    }
}
