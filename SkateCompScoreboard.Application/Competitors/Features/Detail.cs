﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using SkateCompScoreboard.Core.Entities;
using SkateCompScoreboard.Persistence.Data;

namespace SkateCompScoreboard.Application.Competitors.Features
{
    public class Detail
    {
        public class Query : IRequest<Competitor>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Competitor>
        {
            public DataContext _context { get; }

            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<Competitor> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Competitors.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            }
        }
    }
}
