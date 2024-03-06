using MediatR;
using SkateCompScoreboard.Persistence.Data;

namespace SkateCompScoreboard.Application.LineSections.Features
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
                var competition = await _context.LineSections.FindAsync(request.Id);

                if (competition == null) { return Unit.Value; }

                _context.Remove(competition);
                await _context.SaveChangesAsync();
                return Unit.Value;
            }
        }
    }
}
