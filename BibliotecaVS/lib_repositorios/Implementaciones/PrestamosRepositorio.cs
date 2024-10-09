using lib_entidades;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class PrestamosRepositorio : IPrestamosRepositorio
    {
        private Conexion? conexion = null;

        public PrestamosRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Prestamos> Listar()
        {
            return conexion!.Listar<Prestamos>();
        }

        public List<Prestamos> Buscar(Expression<Func<Prestamos, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Prestamos Guardar(Prestamos entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Prestamos Modificar(Prestamos entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Prestamos Borrar(Prestamos entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public void BuscarXUsuario(int idUsuario)
        {

        }
    }
}