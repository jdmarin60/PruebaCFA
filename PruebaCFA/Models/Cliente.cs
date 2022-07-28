using System.ComponentModel.DataAnnotations;

namespace PruebaCFA.Models
{
    public class Cliente
    {
        [Key]
        [Required]
        public long Codigo { get; set; }

        [Required]
        public string TipoDocumento { get; set; }

        [Required]
        public long NumeroDocumento { get; set; }

        [Required]
        [MaxLength(30)]
        public string Nombres { get; set; }

        [Required]
        [MaxLength(30)]
        public string Apellido1 { get; set; }

        [MaxLength(30)]
        public string Apellido2 { get; set; }

        [Required]
        public string Genero { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento { get; set; }
    }
}
