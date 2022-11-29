using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    public class Distrito
    {
        [Key]
        public int codigo_distrito { get; set; }
        [Display(Name = "Nombre Distrito")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(50, ErrorMessage = "Longitud máxima 50", MinimumLength = 8)]
        public string? nombre_distrito { get; set; }
    }
}
