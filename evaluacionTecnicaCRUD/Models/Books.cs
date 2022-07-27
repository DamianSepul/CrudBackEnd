using System.ComponentModel.DataAnnotations;

namespace evaluacionTecnicaCRUD.Models
{
    public class Books
    {
        //Modelo en el cual se basara para realizar la base de datos, se agregan sus respectivas restricciones y sus atributos
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El titulo es obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Título")]

        public string Title { get; set; }

        [Required(ErrorMessage = "La Descripción es obligatoria")]
        [StringLength(100, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Descripción")]

        public string Description { get; set; }

        [Required(ErrorMessage = "La Fecha es obligatoria")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Lanzamiento")]

        public DateTime ReleasedDate { get; set; }

        [Required(ErrorMessage = "El Autor es obligatorio")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "El Precio es obligatorio")]
        public int Price { get; set; }
    }
}
