using lib_entidades;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface INotasRepositorio
    {
        List<Notas> Listar();
        List<Notas> Buscar(Expression<Func<Notas, bool>> condiciones);
        Notas Guardar(Notas entidad);
        Notas Modificar(Notas entidad);
        Notas Borrar(Notas entidad);
    }
}