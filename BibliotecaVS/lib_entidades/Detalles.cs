namespace lib_entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Detalles
    {
        //Propiedades
        [Key] public int Id { get; set; }
        public int Libro { get; set; }
        public int Prestamo { get; set; }
        [NotMapped] public Libros? _Libro { get; set; }
        [NotMapped] public Prestamos? _Prestamo { get; set; }
    }
}
