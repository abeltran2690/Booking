using System.ComponentModel.DataAnnotations;

namespace Bookings.Entities
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 40)]
        public string Name { get; set; }
    }
}
