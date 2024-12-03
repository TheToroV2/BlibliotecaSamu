using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_presentaciones.Interfaces
{
    public interface IPersonasPresentacion
    {
        Task<List<Personas>> Listar();
        Task<List<Personas>> Buscar(Personas entidad, string tipo);
        Task<Personas> Guardar(Personas entidad);
        Task<Personas> Modificar(Personas entidad);
        Task<Personas> Borrar(Personas entidad);
    }
}
