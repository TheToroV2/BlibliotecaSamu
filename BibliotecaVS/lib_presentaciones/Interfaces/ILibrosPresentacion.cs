using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_presentaciones.Interfaces
{
    public interface ILibrosPresentacion
    {
        Task<List<Libros>> Listar();
        Task<List<Libros>> Buscar(Libros entidad, string tipo);
        Task<Libros> Guardar(Libros entidad);
        Task<Libros> Modificar(Libros entidad);
        Task<Libros> Borrar(Libros entidad);
    }
}
