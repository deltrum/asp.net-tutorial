using System;
using server.Models;

namespace server.Dtos
{
    public class CommandDto
    {
        public int Id { get; set; }

        public string CmdLine { get; set; }

        public DateTime RecordDate { get; set; }

        public int? PlatformId { get; set; }

        public virtual Platform Platform { get; set; }
    }
}