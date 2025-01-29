namespace lib_entidades.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    public class Prestamos
    {
        //Propiedades
        [Key] public int Id { get; set; }
        public string? Numero { get; set; }
        public DateTime? Fecha { get; set; }
        public int Usuario { get; set; }
        [NotMapped] public Usuarios? _Usuario { get; set; }
        [NotMapped] public ICollection<Detalles>? Detalles { get; set; }

        [NotMapped] public ICollection<Notas>? Notas { get; set; }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(Numero) ||
                (Usuario <= 0) ||
                Fecha == null)
            {
                return false;
            }
            return true;
        }

    }
}

