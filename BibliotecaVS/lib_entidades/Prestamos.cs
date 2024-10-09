namespace lib_entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

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

    }
}

