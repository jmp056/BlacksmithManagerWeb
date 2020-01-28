using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlacksmithManagerWeb.Data
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "La cedula es obligatoria")]
        [StringLength(maximumLength: 13, MinimumLength = 13, ErrorMessage = "Debe ingresar una cedula valida")]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "El numero de celular es obligatorio")]
        [StringLength(maximumLength: 12, MinimumLength = 12, ErrorMessage = "Debe ingresar un numero de celular valido")]
        public string Celular { get; set; }
        [Required(ErrorMessage = "El numero de telefono es obligatorio")]
        [StringLength(maximumLength: 12, MinimumLength = 12, ErrorMessage = "Debe ingresar un numero de telefono valido")]
        public string Telefono { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
