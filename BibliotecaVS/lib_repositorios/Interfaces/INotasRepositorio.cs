using lib_entidades.Modelos;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface INotasRepositorio
    {
        void Configurar(string string_conexion);
        List<Notas> Listar();
        List<Notas> Buscar(Expression<Func<Notas, bool>> condiciones);
        Notas Guardar(Notas entidad);
        Notas Modificar(Notas entidad);
        Notas Borrar(Notas entidad);
    }
}