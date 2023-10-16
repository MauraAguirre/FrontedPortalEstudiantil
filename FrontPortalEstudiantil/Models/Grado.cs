using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FrontPortalEstudiantil.Models
{
    public class Grado
    {
        public Int16 Id { get; set; }

        [Required(ErrorMessage = " Nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "máximo 50 caracteres")]

        public string Nombre { get; set; }

        //[NotMapped]
        //public int Top_Aux { get; set; }

        //public List<Docente> docente { get; set; }
        //[ValidateNever]
        //public List<Estudiante> Estudiante { get; set; }
        //[ValidateNever]
        //public List<Horario> horario { get; set; }
    }
}
