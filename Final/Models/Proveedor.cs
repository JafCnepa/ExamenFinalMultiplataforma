using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final.Models
{
    public class Proveedor
    {
        [Key]
        public int cod_provedor { get; set; }
        [Display(Name = "Razon Social")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(50, ErrorMessage = "Longitud máxima 50", MinimumLength = 8)]
        public string? razonsocial { get; set; }
        [Display(Name = "Direccion")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(50, ErrorMessage = "Longitud máxima 50", MinimumLength = 8)]
        public string? direccion { get; set; }
        [Display(Name = "Repartidor")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(50, ErrorMessage = "Longitud máxima 50", MinimumLength = 8)]
        public string? telefono { get; set; }
        [Display(Name = "Telefono")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(50, ErrorMessage = "Longitud máxima 9", MinimumLength = 9)]
        public string? repartidor { get; set; }
        [ForeignKey("codigo_distrito")]
        public int codigo_distrito { get; set; }
        public virtual Distrito Distritos { get; set; }

    }
}
