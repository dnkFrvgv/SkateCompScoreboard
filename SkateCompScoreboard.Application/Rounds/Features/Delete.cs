using MediatR;
using SkateCompScoreboard.Persistence.Data;

namespace SkateCompScoreboard.Application.Rounds.Features
{
    public class Delete
    {
        public class Command : IRequest<Unit>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var round = await _context.Rounds.FindAsync(request.Id);

                if (round == null) { return Unit.Value; }

                _context.Remove(round);
                await _context.SaveChangesAsync();
                return Unit.Value;
            }
        }
    }
}
