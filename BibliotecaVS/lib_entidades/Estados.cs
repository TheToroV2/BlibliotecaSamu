namespace lib_entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Estados
    {
        //Propiedades
        [Key] public int Id { get; set; }
        public string? Nombre { get; set; }
        [NotMapped] public ICollection<Libros>? Libros { get; set; }

    }
}
