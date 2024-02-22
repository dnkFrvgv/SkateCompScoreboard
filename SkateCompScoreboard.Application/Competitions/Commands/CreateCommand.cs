using MediatR;
using SkateCompScoreboard.Core.Entities;
using SkateCompScoreboard.Persistence.Data;
namespace SkateCompScoreboard.Application.Competitions.Commands
{
    public class CreateCommand
    {
        public class Command : IRequest<Unit>
        {
            public Competition Competition { get; set; }
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

                _context.Competitions.Add(request.Competition);
                await _context.SaveChangesAsync();
                return Unit.Value;
            }
        }
    }
}
