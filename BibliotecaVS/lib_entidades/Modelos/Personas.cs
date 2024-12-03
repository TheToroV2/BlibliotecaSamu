namespace lib_entidades.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Personas
    {
        //Propiedades
        [Key] public int Id { get; set; }
        public string? Cedula { get; set; }
        public string? Nombre { get; set; }
        [NotMapped] public ICollection<Usuarios>? Usuarios { get; set; }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(Cedula) ||
                string.IsNullOrEmpty(Nombre))
            {
                return false;
            }
            return true;
        }
    }
}
