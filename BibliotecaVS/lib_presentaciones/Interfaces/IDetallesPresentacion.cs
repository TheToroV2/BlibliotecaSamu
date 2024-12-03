using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_presentaciones.Interfaces
{
    public interface IDetallesPresentacion
    {
        Task<List<Detalles>> Listar();
        Task<List<Detalles>> Buscar(Detalles entidad, string tipo);
        Task<Detalles> Guardar(Detalles entidad);
        Task<Detalles> Modificar(Detalles entidad);
        Task<Detalles> Borrar(Detalles entidad);
    }
}
