using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriveNation.Data.Entities
{
    public class Car
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string? Model { get; set; }
        //Year does not have [Range] attribute because it does not accept Date.Now.Year
        //Year validation will be done in Controller
        [Required]
        public int Year { get; set; }
        [Required]
        [Range(1, 12)]
        [DisplayName("Passenger Capacity")]
        public int PassengerCapacity { get; set; }
        [Required]
        [StringLength(250, MinimumLength = 5)]
        public string? Description { get; set; }
        [Required]
        [DisplayName("Rent Price")]
        public decimal RentPrice { get; set; }
        [Required]
        public int BrandId { get; set; }

        [Required]
        [ForeignKey("BrandId")]
        public Brand? Brand { get; set; }
    }
}
