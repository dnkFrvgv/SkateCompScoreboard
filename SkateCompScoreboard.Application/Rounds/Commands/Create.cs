using MediatR;
using SkateCompScoreboard.Core.Entities;
using SkateCompScoreboard.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateCompScoreboard.Application.Rounds.Commands
{
    public class Create
    {
        public class Command : IRequest<Unit>
        {
            public Round Round { get; set; }
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

                _context.Rounds.Add(request.Round);
                await _context.SaveChangesAsync();
                return Unit.Value;
            }
        }
    }
}
