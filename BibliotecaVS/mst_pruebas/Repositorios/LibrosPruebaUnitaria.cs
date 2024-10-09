using lib_entidades;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class LibrosPruebaUnitaria
    {
        private ILibrosRepositorio? iRepositorio = null;
        private Libros? entidad = null;

        public LibrosPruebaUnitaria()
        {
            var conexion = new Conexion();
            conexion.StringConnection = "server=ANXKY\\SQLEXPRESS;database=DB_BIBLIOTECA;Integrated Security=True;TrustServerCertificate=true;";
            iRepositorio = new LibrosRepositorio(conexion);
        }

        [TestMethod]
        public void Ejecutar()
        {
            Guardar();
            Listar();
            Buscar();
            Modificar();
            Borrar();
        }

        private void Guardar()
        {
            entidad = new Libros()
            {
                Nombre   = "TestNombre",
                Autor = "TestAutor",
                Estado = 3
            };
            entidad = iRepositorio!.Guardar(entidad);
            Assert.IsTrue(entidad.Id != 0);
        }

        private void Listar()
        {
            var lista = iRepositorio!.Listar();
            Assert.IsTrue(lista.Count > 0);
        }

        public void Buscar()
        {
            var lista = iRepositorio!.Buscar(x => x.Id == entidad!.Id);
            Assert.IsTrue(lista.Count > 0);
        }

        private void Modificar()
        {
            entidad!.Nombre = "Cambio Test";
            entidad = iRepositorio!.Modificar(entidad!);
            Assert.IsTrue(entidad!.Nombre == "Cambio Test");
        }

        private void Borrar()
        {
            entidad = iRepositorio!.Borrar(entidad!);

            var lista = iRepositorio!.Buscar(x => x.Id == entidad!.Id);
            Assert.IsTrue(lista.Count == 0);
        }
    }
}