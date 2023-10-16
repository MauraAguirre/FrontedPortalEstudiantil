﻿using System.ComponentModel.DataAnnotations;

namespace FrontPortalEstudiantil.Models
{
    public class Turno
    {
        public Int16 Id { get; set; }

        [Required(ErrorMessage = " Nombre es obligatorio")]
        public string Nombre { get; set; }
    }
}
