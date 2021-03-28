using System;
using System.Collections.Generic;

namespace server.Models
{
    public class Platform : IPlatform
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime RecordDate { get; set; }

        public virtual ICollection<Command> OwnedCommands { get; set; }
    }
}