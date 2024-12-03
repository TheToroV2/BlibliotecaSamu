using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_presentaciones.Interfaces
{
    public interface IUsuariosPresentacion
    {
        Task<List<Usuarios>> Listar();
        Task<List<Usuarios>> Buscar(Usuarios entidad, string tipo);
        Task<Usuarios> Guardar(Usuarios entidad);
        Task<Usuarios> Modificar(Usuarios entidad);
        Task<Usuarios> Borrar(Usuarios entidad);
    }
}
