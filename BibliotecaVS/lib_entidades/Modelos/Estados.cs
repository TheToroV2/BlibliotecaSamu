namespace lib_entidades.Modelos
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

        public bool Validar()
        {
            if (string.IsNullOrEmpty(Nombre))
                return false;
            return true;
        }

    }
}
