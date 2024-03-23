using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DriveNation
{
    public class RentACarUser : IdentityUser
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string? FirstName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string? LastName { get; set; }
        [Required]
        [RegularExpression(@"^\d+$")]
        [StringLength(10, MinimumLength = 10)]
        public string? Personal_Id { get; set; }
    }
}
