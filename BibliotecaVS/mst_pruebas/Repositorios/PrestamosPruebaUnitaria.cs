using lib_entidades;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class PrestamosPruebaUnitaria
    {
        private IPrestamosRepositorio? iRepositorio = null;
        private Prestamos? entidad = null;

        public PrestamosPruebaUnitaria()
        {
            var conexion = new Conexion();
            conexion.StringConnection = "server=ANXKY\\SQLEXPRESS;database=DB_BIBLIOTECA;Integrated Security=True;TrustServerCertificate=true;";
            iRepositorio = new PrestamosRepositorio(conexion);
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
            entidad = new Prestamos()
            {
                Numero = "123414113",
                Fecha = DateTime.Now,
                Usuario = 3
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
            entidad!.Numero = "11111111";
            entidad = iRepositorio!.Modificar(entidad!);
            Assert.IsTrue(entidad!.Numero == "11111111");
        }

        private void Borrar()
        {
            entidad = iRepositorio!.Borrar(entidad!);

            var lista = iRepositorio!.Buscar(x => x.Id == entidad!.Id);
            Assert.IsTrue(lista.Count == 0);
        }
    }
}