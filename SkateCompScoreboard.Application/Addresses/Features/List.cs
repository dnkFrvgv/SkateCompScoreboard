using MediatR;
using Microsoft.EntityFrameworkCore;
using SkateCompScoreboard.Core.Entities;
using SkateCompScoreboard.Persistence.Data;

namespace SkateCompScoreboard.Application.Addresses.Features
{
    public class List
    {
        public class Query : IRequest<List<Address>> { }

        public class Handler : IRequestHandler<Query, List<Address>>
        {
            private DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<List<Address>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Addresses.ToListAsync(cancellationToken);
            }
        }
    }
}
