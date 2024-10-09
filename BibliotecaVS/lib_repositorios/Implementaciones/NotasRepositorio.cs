using lib_entidades;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class NotasRepositorio : INotasRepositorio
    {
        private Conexion? conexion = null;

        public NotasRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Notas> Listar()
        {
            return conexion!.Listar<Notas>();
        }

        public List<Notas> Buscar(Expression<Func<Notas, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Notas Guardar(Notas entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Notas Modificar(Notas entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Notas Borrar(Notas entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}