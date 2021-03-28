using System.ComponentModel.DataAnnotations;

namespace commandor.Models
{
    public class Command
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CommandLine { get; set; }

        [Required]
        public string Desc { get; set; }

        [Required]
        public int PlatformId { get; set; }

        public Platform Platform { get; set; }
    }
}