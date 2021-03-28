using System.Linq;
using commandor.Data;
using commandor.Models;
using HotChocolate;
using HotChocolate.Data;

namespace commandor.GQL
{
    public class Query
    {
        [UseDbContext(typeof(DatabaseContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Platform> GetPlatform([ScopedService] DatabaseContext context)
        {
            return context.Platforms;
        }

        [UseDbContext(typeof(DatabaseContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Command> GetCommand([ScopedService] DatabaseContext context)
        {
            return context.Commands;
        }
    }
}