using lib_entidades;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class LibrosRepositorio : ILibrosRepositorio
    {
        private Conexion? conexion = null;

        public LibrosRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Libros> Listar()
        {
            return conexion!.Listar<Libros>();
        }

        public List<Libros> Buscar(Expression<Func<Libros, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Libros Guardar(Libros entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Libros Modificar(Libros entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Libros Borrar(Libros entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public void BuscarXAutor(int idAutor)
        {

        }

        public void CambiarEstado(int idEstado)
        {

        }
    }
}