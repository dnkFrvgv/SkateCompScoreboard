using AutoMapper;
using MediatR;
using SkateCompScoreboard.Core.Entities;
using SkateCompScoreboard.Persistence.Data;

namespace SkateCompScoreboard.Application.SingleTrickSections.Features
{
    public class Edit
    {
        public class Command : IRequest<Unit>
        {
            public SingleTrickSection SingleTrickSection { get; set; }
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
                var singleTrickSection = await _context.SingleTrickSections.FindAsync(request.SingleTrickSection.Id, cancellationToken);

                _mapper.Map(request.SingleTrickSection, singleTrickSection);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}
