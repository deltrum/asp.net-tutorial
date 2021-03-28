using System.Threading.Tasks;
using commandor.Data;
using commandor.GQL.Platforms;
using commandor.Models;
using HotChocolate;
using HotChocolate.Data;

namespace commandor.GQL
{
    public class Mutation
    {
        [UseDbContext(typeof(DatabaseContext))]
        public async Task<AddPlatformPayload> AddPlatformAsync(AddPlatformInput input,
        [ScopedService] DatabaseContext context)
        {
            var platform = new Platform
            {
                Name = input.Name
            };

            context.Platforms.Add(platform);
            await context.SaveChangesAsync();

            return new AddPlatformPayload(platform);
        }
    }
}