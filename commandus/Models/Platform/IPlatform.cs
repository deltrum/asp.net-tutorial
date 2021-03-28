using System;
using System.Collections.Generic;

namespace server.Models
{
    public interface IPlatform
    {
        int Id { get; set; }

        string Name { get; set; }

        DateTime RecordDate { get; set; }

        ICollection<Command> OwnedCommands { get; set; }
    }
}