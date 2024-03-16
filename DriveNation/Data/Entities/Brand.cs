using System.ComponentModel.DataAnnotations;

namespace DriveNation.Data.Entities
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string? Name { get; set; }
    }
}
