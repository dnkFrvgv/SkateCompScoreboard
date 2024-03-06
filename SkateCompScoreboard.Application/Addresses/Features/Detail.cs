using MediatR;
using Microsoft.EntityFrameworkCore;
using SkateCompScoreboard.Core.Entities;
using SkateCompScoreboard.Persistence.Data;

namespace SkateCompScoreboard.Application.Addresses.Features
{
    public class Detail
    {
        public class Query : IRequest<Address>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Address>
        {
            public DataContext _context { get; }

            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<Address> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Addresses.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            }
        }
    }
}
