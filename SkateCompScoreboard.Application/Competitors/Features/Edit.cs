using AutoMapper;
using MediatR;
using SkateCompScoreboard.Core.Entities;
using SkateCompScoreboard.Persistence.Data;

namespace SkateCompScoreboard.Application.Competitors.Features
{
    public class Edit
    {
        public class Command : IRequest<Unit>
        {
            public Competitor Competitor { get; set; }
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
                var competitor = await _context.Competitors.FindAsync(request.Competitor.Id, cancellationToken);

                _mapper.Map(request.Competitor, competitor);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}
