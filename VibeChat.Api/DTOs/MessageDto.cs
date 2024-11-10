using System.ComponentModel.DataAnnotations;

namespace VibeChat.Api.DTOs
{
    public class MessageDto
    {
        [Required]
        public string From { get; set; }
        public string To { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
