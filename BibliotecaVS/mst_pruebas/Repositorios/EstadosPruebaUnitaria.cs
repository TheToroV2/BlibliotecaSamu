using lib_entidades;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class EstadosPruebaUnitaria
    {
        private IEstadosRepositorio? iRepositorio = null;
        private Estados? entidad = null;

        public EstadosPruebaUnitaria()
        {
            var conexion = new Conexion();
            conexion.StringConnection = "server=ANXKY\\SQLEXPRESS;database=DB_BIBLIOTECA;Integrated Security=True;TrustServerCertificate=true;";
            iRepositorio = new EstadosRepositorio(conexion);
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
            entidad = new Estados()
            {
                Nombre = "TestNombre",
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
            entidad!.Nombre = "CambioTest";
            entidad = iRepositorio!.Modificar(entidad!);
            Assert.IsTrue(entidad!.Nombre == "CambioTest");
        }

        private void Borrar()
        {
            entidad = iRepositorio!.Borrar(entidad!);

            var lista = iRepositorio!.Buscar(x => x.Id == entidad!.Id);
            Assert.IsTrue(lista.Count == 0);
        }
    }
}