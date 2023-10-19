using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FrontPortalEstudiantil.Models
{
    public class EditDocente
    {
        public Int16 Id { get; set; }

        [Required(ErrorMessage = "Nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Apellido es obligatorio")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El código de docente es obligatorio")]
        public string CodigoDocente { get; set; }

        [Required(ErrorMessage = "La clave es obligatoria")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string Clave { get; set; }

        [ForeignKey("Rol")]
        [Display(Name = "Rol")]
        public Int16 RolId { get; set; }

        [ForeignKey("Materia")]
        [Required(ErrorMessage = "La materia es obligatoria")]
        [Display(Name = "Materia")]
        public Int16 MateriaId { get; set; }

        [ForeignKey("Ciclo")]
        [Required(ErrorMessage = "El ciclo encargado es obligatorio")]
        [Display(Name = "Ciclo")]
        public Int16 CicloId { get; set; }

        [ForeignKey("Turno")]
        [Required(ErrorMessage = "El turno es obligatorio")]
        [Display(Name = "Turno")]
        public Int16 TurnoId { get; set; }

        [Required(ErrorMessage = "El DUI es obligatorio")]
        [Display(Name = "Dui")]
        public Int32 DUI { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "La dirección es obligatorio")]
        public string Dirección { get; set; }

        [Required(ErrorMessage = "El número de teléfono es obligatorio")]
        [Display(Name = "Telefono")]
        public Int32 Telefono { get; set; }
        [Required(ErrorMessage = "Estatus es obligatorio")]
        public int Estatus { get; set; }

        //[ValidateNever]
        //public Rol Rol { get; set; }
        //[ValidateNever]
        public Materia Materia { get; set; }
        //[ValidateNever]
        public Ciclo Ciclo { get; set; }
        //[ValidateNever]
        public Turno Turno { get; set; }
    }
}
