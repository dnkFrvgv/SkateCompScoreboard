using MediatR;
using SkateCompScoreboard.Core.Entities;
using SkateCompScoreboard.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SkateCompScoreboard.Application.Rounds.Features
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
                var competition = await _context.Competitions.FindAsync(request.Round.CompetitionId, cancellationToken);

                if (competition == null) return Unit.Value;

                request.Round.Competition = competition;

                _context.Rounds.Add(request.Round);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}
