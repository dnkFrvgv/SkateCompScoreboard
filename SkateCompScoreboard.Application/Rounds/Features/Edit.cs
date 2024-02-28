using AutoMapper;
using MediatR;
using SkateCompScoreboard.Core.Entities;
using SkateCompScoreboard.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateCompScoreboard.Application.Rounds.Features
{
    public class Edit
    {
        public class Command : IRequest<Unit> 
        {
            public Round Round { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;

            public Handler(DataContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }
            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var round = await _context.Rounds.FindAsync(request.Round.Id, cancellationToken);

                _mapper.Map(request.Round, round);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}
