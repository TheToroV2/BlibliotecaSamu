using lib_entidades.Modelos;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface ILibrosRepositorio
    {
        void Configurar(string string_conexion);
        List<Libros> Listar();
        List<Libros> Buscar(Expression<Func<Libros, bool>> condiciones);
        Libros Guardar(Libros entidad);
        Libros Modificar(Libros entidad);
        Libros Borrar(Libros entidad);
    }
}