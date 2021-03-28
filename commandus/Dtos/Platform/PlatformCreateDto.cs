using System.ComponentModel.DataAnnotations;

namespace server.Dtos
{
    public class PlatformCreateDto
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}