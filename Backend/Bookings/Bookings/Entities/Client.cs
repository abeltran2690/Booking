using System.ComponentModel.DataAnnotations;

namespace Bookings.Entities
{
    public class Client
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 50)]
        public string Surname { get; set; }
        public string identificationType  { get; set; }
        public int identification { get; set; }

    }
}
