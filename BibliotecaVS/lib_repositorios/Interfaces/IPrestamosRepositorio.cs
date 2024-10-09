using lib_entidades;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface IPrestamosRepositorio
    {
        List<Prestamos> Listar();
        List<Prestamos> Buscar(Expression<Func<Prestamos, bool>> condiciones);
        Prestamos Guardar(Prestamos entidad);
        Prestamos Modificar(Prestamos entidad);
        Prestamos Borrar(Prestamos entidad);
    }
}