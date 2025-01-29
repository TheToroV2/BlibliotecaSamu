namespace lib_entidades.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    public class Detalles
    {
        //Propiedades
        [Key] public int Id { get; set; }
        public int Libro { get; set; }
        public int Prestamo { get; set; }
        [NotMapped] public Libros? _Libro { get; set; }
        [NotMapped] public Prestamos? _Prestamo { get; set; }

        public bool Validar()
        {
            // Verificar si existe un libro asociado y si el número del libro es válido
            if (Libro <= 0 || _Libro == null)
            {
                return false;
            }

            // Verificar si el préstamo está asociado correctamente
            if (Prestamo <= 0 || _Prestamo == null)
            {
                return false;
            }

            return true;
        }
    }
}
