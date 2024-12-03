using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_presentaciones.Interfaces
{
    public interface IEstadosPresentacion
    {
        Task<List<Estados>> Listar();
        Task<List<Estados>> Buscar(Estados entidad, string tipo);
        Task<Estados> Guardar(Estados entidad);
        Task<Estados> Modificar(Estados entidad);
        Task<Estados> Borrar(Estados entidad);
    }
}
