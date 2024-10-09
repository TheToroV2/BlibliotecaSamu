namespace lib_entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Libros
    {
        //Propiedades
        [Key] public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Autor { get; set; }
        public int Estado { get; set; }
        [NotMapped] public Estados? _Estado { get; set; }
        [NotMapped] public ICollection<Detalles>? Detalles { get; set; }

    }
}
