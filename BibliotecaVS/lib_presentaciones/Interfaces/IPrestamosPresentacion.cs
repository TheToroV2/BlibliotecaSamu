using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_presentaciones.Interfaces
{
    public interface IPrestamosPresentacion
    {
        Task<List<Prestamos>> Listar();
        Task<List<Prestamos>> Buscar(Prestamos entidad, string tipo);
        Task<Prestamos> Guardar(Prestamos entidad);
        Task<Prestamos> Modificar(Prestamos entidad);
        Task<Prestamos> Borrar(Prestamos entidad);
    }
}
