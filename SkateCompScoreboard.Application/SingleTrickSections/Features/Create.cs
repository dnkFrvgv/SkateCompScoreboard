using MediatR;
using SkateCompScoreboard.Core.Entities;
using SkateCompScoreboard.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateCompScoreboard.Application.SingleTrickSections.Features
{
    public class Create
    {
        public class Command : IRequest<Unit>
        {
            public Guid RoundId { get; set; }
            public SingleTrickSection SingleTrickSection { get; set; }
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

                request.SingleTrickSection.Round = round;

                _context.SingleTrickSections.Add(request.SingleTrickSection);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}
