using MediatR;
using SkateCompScoreboard.Persistence.Data;

namespace SkateCompScoreboard.Application.Competitors.Features
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
                var competitor = await _context.Competitors.FindAsync(request.Id);

                if (competitor == null) { return Unit.Value; }

                _context.Remove(competitor);
                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}
