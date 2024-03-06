using MediatR;
using SkateCompScoreboard.Core.Entities;
using SkateCompScoreboard.Persistence.Data;

namespace SkateCompScoreboard.Application.LineSections.Features
{
    public class Create
    {
        public class Command : IRequest<Unit>
        {
            public Guid RoundId { get; set; }
            public LineSection LineSection { get; set; }
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
                var round = await _context.Rounds.FindAsync(request.RoundId, cancellationToken);

                if (round == null) return Unit.Value;

                request.LineSection.Round = round;

                _context.LineSections.Add(request.LineSection);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}
