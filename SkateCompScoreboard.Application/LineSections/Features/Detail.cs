using MediatR;
using Microsoft.EntityFrameworkCore;
using SkateCompScoreboard.Core.Entities;
using SkateCompScoreboard.Persistence.Data;

namespace SkateCompScoreboard.Application.LineSections.Features
{
    public class Detail
    {
        public class Query : IRequest<LineSection>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, LineSection>
        {
            public DataContext _context { get; }

            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<LineSection> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.LineSections.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            }
        }
}
