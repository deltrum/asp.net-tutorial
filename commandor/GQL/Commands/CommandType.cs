using System.Linq;
using commandor.Data;
using commandor.Models;
using HotChocolate;
using HotChocolate.Types;

namespace commandor.GQL.Commands
{
    public class CommandType : ObjectType<Command>
    {
        protected override void Configure(IObjectTypeDescriptor<Command> descriptor)
        {
            descriptor.Description("Represents any executable command");

            descriptor
            .Field(c => c.Platform)
            .ResolveWith<Resolvers>(c => c.GetPlatform(default!, default!))
            .UseDbContext<DatabaseContext>()
            .Description("A  platform where the command can be executed");
        }

        private class Resolvers
        {
            public Platform GetPlatform(Command command, [ScopedService] DatabaseContext context)
            {
                return context.Platforms.FirstOrDefault(p => p.Id == command.PlatformId);
            }
        }
    }
}