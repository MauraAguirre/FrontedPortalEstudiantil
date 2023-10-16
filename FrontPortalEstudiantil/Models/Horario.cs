using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FrontPortalEstudiantil.Models
{
    public class Horario
    {
        public Int16 Id { get; set; }

        [ForeignKey("Grado")]
        public Int16 GradoId { get; set; }

        [ForeignKey("Materia")]
        public Int16 MateriaId { get; set; }

        [ForeignKey("Docente")]
        public Int16 DocenteId { get; set; }

        [Required(ErrorMessage = "El dia es obligatorio")]
        public string Dia { get; set; }

        [Required(ErrorMessage = "El Horario en que inicia es obligatorio")]
        public string HorarioInicio { get; set; }

        [Required(ErrorMessage = "El horario en que termina es obligatorio")]
        public string HorarioSalida { get; set; }

        //[ValidateNever]
        public Grado Grado { get; set; }

        //[ValidateNever]
        public Materia Materia { get; set; }

        //[ValidateNever]
        public Docente Docente { get; set; }

    }
}
