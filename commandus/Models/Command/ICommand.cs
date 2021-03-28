using System;

namespace server.Models
{
    public interface ICommand
    {
        int Id { get; set; }

        string CmdLine { get; set; }

        DateTime RecordDate { get; set; }

        int? PlatformId { get; set; }

        Platform Platform { get; set; }
    }
}