using MediatR;
using Microsoft.EntityFrameworkCore;
using SkateCompScoreboard.Core.Entities;
using SkateCompScoreboard.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateCompScoreboard.Application.Rounds.Features
{
    public class List
    {
        public class Query : IRequest<List<Round>> { }

        public class Handler : IRequestHandler<Query, List<Round>>
        {
            private DataContext _context;

            public Handler(DataContext context) {
                _context = context;
            }
            public async Task<List<Round>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Rounds.ToListAsync(cancellationToken);
            }
        }
    }
}
