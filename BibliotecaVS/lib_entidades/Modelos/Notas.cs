namespace lib_entidades.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Notas
    {
        //Propiedades
        [Key] public int Id { get; set; }
        public string? Descripcion { get; set; }
        public int Prestamo { get; set; }
        [NotMapped] public Prestamos? _Prestamo { get; set; }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(Descripcion)|| (Prestamo <= 0))
            {
                return false;
            }
            return true;
        }
    }
}
