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
    public class Detail
    {
        public class Query : IRequest<Round>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Round>
        {
            public DataContext _context { get; }

            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<Round> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Rounds.FindAsync(request.Id, cancellationToken);
            }
        }
    }
}
