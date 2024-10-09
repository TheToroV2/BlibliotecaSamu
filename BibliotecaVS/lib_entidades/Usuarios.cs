namespace lib_entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Usuarios
    {
        //Propiedades
        [Key] public int Id { get; set; }
        public string? Usuario { get; set; }
        public string? Contraseña { get; set; }
        public int Persona { get; set; }
        [NotMapped] public Personas? _Persona { get; set; }
        [NotMapped] public ICollection<Prestamos>? Prestamos { get; set; }

    }
}
