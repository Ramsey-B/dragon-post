using System.ComponentModel.DataAnnotations;

namespace dragon_post.Models
{
    public class ChangeUserPasswordModel
    {
        public string Id { get; set; }
        [MaxLength(255), EmailAddress]
        public string Email { get; set; }
        [Required, MinLength(4)]
        public string OldPassword { get; set; }
        [Required, MinLength(4)]
        public string NewPassword { get; set; }
    }
}