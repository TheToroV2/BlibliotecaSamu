namespace lib_entidades.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    public class Usuarios
    {
        //Propiedades
        [Key] public int Id { get; set; }
        public string? Usuario { get; set; }
        public string? Contraseña { get; set; }
        public int Persona { get; set; }
        [NotMapped] public Personas? _Persona { get; set; }
        [NotMapped] public ICollection<Prestamos>? Prestamos { get; set; }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(Usuario) ||
                string.IsNullOrEmpty(Contraseña))
            {
                return false;
            }
            return true;
        }
    }
}
