namespace lib_entidades.Modelos
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

        public bool Validar()
        {
            if (string.IsNullOrEmpty(Nombre) ||
                string.IsNullOrEmpty(Autor))
            {  
                return false; 
            }
            if(Estado <= 0)
            {
                    return false;
            }
            return true;
        }
    }
}
