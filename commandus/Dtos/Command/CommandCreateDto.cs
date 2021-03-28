using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using server.Models;

namespace server.Dtos
{
    public class CommandCreateDto
    {
        [Required]
        [MaxLength(200)]
        public string CmdLine { get; set; }

        [Required]
        [ForeignKey("Platform")]
        public int? PlatformId { get; set; }

        public virtual Platform Platform { get; set; }
    }
}