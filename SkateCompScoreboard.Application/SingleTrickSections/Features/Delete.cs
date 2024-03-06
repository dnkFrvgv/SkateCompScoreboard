using MediatR;
using SkateCompScoreboard.Persistence.Data;

namespace SkateCompScoreboard.Application.SingleTrickSections.Features
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
                var singleTrickSection = await _context.SingleTrickSections.FindAsync(request.Id);

                if (singleTrickSection == null) { return Unit.Value; }

                _context.Remove(singleTrickSection);
                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}
