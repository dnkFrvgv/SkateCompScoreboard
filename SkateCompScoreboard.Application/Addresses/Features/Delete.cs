using MediatR;
using SkateCompScoreboard.Persistence.Data;

namespace SkateCompScoreboard.Application.Addresses.Features
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
                var address = await _context.Addresses.FindAsync(request.Id);

                if (address == null) { return Unit.Value; }

                _context.Remove(address);
                await _context.SaveChangesAsync();
                return Unit.Value;
            }
        }
    }
}
