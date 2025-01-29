using lib_aplicaciones.Interfaces;
using lib_repositorios.Interfaces;
using lib_entidades.Modelos;
using System.Linq.Expressions;
namespace lib_aplicaciones.Implementaciones
{
    public class LibrosAplicacion : ILibrosAplicacion
    {
        private ILibrosRepositorio? iRepositorio = null;
        public LibrosAplicacion(ILibrosRepositorio iRepositorio)
        {
            this.iRepositorio = iRepositorio;
        }
        public void Configurar(string string_conexion)
        {
            this.iRepositorio!.Configurar(string_conexion);
        }
        public Libros Borrar(Libros entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0)
                throw new Exception("lbNoSeGuardo");
            entidad = iRepositorio!.Borrar(entidad);
            return entidad;
        }
        public Libros Guardar(Libros entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0)
                throw new Exception("lbYaSeGuardo");
            //entidad = Calcular(entidad);
            entidad = iRepositorio!.Guardar(entidad);
            return entidad;
        }
        public List<Libros> Listar()
        {
            return iRepositorio!.Listar();
        }
        public List<Libros> Buscar(Libros entidad, string tipo)
        {
            Expression<Func<Libros, bool>>? condiciones = null;
            switch (tipo.ToUpper())
            {
                //case "NOMBRE": condiciones = x => x.Persona!.Contains(entidad.Persona!); break;
                default: condiciones = x => x.Id == entidad.Id; break;
            }
            return this.iRepositorio!.Buscar(condiciones);
        }
        public Libros Modificar(Libros entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0)
                throw new Exception("lbNoSeGuardo");
            //entidad = Calcular(entidad);
            entidad = iRepositorio!.Modificar(entidad);
            return entidad;
        }
        //private Libros Calcular(Libros entidad)
        //{
        //    entidad.Final = (entidad.Nota1 +
        //    entidad.Nota2 +
        //    entidad.Nota3 +
        //    entidad.Nota4 +
        //    entidad.Nota5) / 5;
        //    entidad.Fecha = DateTime.Now;
        //    return entidad;
        //}
    }
}