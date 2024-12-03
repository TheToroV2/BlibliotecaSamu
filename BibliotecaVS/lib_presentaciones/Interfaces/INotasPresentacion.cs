using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_presentaciones.Interfaces
{
    public interface INotasPresentacion
    {
        Task<List<Notas>> Listar();
        Task<List<Notas>> Buscar(Notas entidad, string tipo);
        Task<Notas> Guardar(Notas entidad);
        Task<Notas> Modificar(Notas entidad);
        Task<Notas> Borrar(Notas entidad);
    }
}
