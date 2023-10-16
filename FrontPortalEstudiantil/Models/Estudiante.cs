using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FrontPortalEstudiantil.Models
{
    public class Estudiante
    {
        public Int16 Id { get; set; }

        [Required(ErrorMessage = "Nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Apellido es obligatorio")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El código de estudiante es obligatorio")]
        public string CodigoEstudiante { get; set; }

        [Required(ErrorMessage = "El grado es obligatorio")]
        public Int16 GradoId { get; set; }

        [Required(ErrorMessage = "El turno es obligatorio")]
        public Int16 TurnoId { get; set; }

        [Required(ErrorMessage = "El encargado del estudiante es obligatorio")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string Encargado { get; set; }

        [Required(ErrorMessage = "El DUI del encargado del estudiante es obligatorio")]
        public Int32 EncargadoDUI { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "La dirección del estudiante es obligatorio")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El número de teléfono es obligatorio")]
        public Int32 Telefono { get; set; }

        //[NotMapped]
        //public int Top_Aux { get; set; }
        //[ValidateNever]
        public Grado Grado { get; set; }
        //[ValidateNever]
        public Turno Turno { get; set; }



    }
}
