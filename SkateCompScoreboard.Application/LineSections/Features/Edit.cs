using AutoMapper;
using MediatR;
using SkateCompScoreboard.Core.Entities;
using SkateCompScoreboard.Persistence.Data;

namespace SkateCompScoreboard.Application.LineSections.Features
{
    public class Edit
    {
        public class Command : IRequest<Unit>
        {
            public LineSection LineSection { get; set; }
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
                var lineSection = await _context.LineSections.FindAsync(request.LineSection.Id, cancellationToken);

                _mapper.Map(request.LineSection, lineSection);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}
