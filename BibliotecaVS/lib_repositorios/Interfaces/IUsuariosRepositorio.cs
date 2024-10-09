using lib_entidades;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface IUsuariosRepositorio
    {
        List<Usuarios> Listar();
        List<Usuarios> Buscar(Expression<Func<Usuarios, bool>> condiciones);
        Usuarios Guardar(Usuarios entidad);
        Usuarios Modificar(Usuarios entidad);
        Usuarios Borrar(Usuarios entidad);
    }
}