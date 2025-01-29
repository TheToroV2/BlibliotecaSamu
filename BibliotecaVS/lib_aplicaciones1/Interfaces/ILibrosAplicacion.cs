using lib_entidades.Modelos;
namespace lib_aplicaciones.Interfaces
{
    public interface ILibrosAplicacion
    {
        void Configurar(string string_conexion);
        List<Libros> Listar();
        List<Libros> Buscar(Libros entidad, string tipo);
        Libros Guardar(Libros entidad);
        Libros Modificar(Libros entidad);
        Libros Borrar(Libros entidad);
    }
}