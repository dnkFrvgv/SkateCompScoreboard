using MediatR;
using Microsoft.EntityFrameworkCore;
using SkateCompScoreboard.Core.Entities;
using SkateCompScoreboard.Persistence.Data;

namespace SkateCompScoreboard.Application.SingleTrickSections.Features
{
    public class List
    {
        public class Query : IRequest<List<SingleTrickSection>> { }

        public class Handler : IRequestHandler<Query, List<SingleTrickSection>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            } 
            public Task<List<SingleTrickSection>> Handle(Query request, CancellationToken cancellationToken)
            {
                return _context.SingleTrickSections.ToListAsync(cancellationToken);
            }
        }
    }
}
