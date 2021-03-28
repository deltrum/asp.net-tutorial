using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.Models
{
    public class Command : ICommand
    {
        public int Id { get; set; }

        public string CmdLine { get; set; }

        public DateTime RecordDate { get; set; }

        [ForeignKey("Platform")]
        public int? PlatformId { get; set; }

        public virtual Platform Platform { get; set; }
    }
}