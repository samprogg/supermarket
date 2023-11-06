using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace shopping.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage="El campo {0} no debe superar la longitud {1}")]
        [Display(Name = "País")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Name { get; set; }
    }
}
