using lib_entidades.Modelos;
namespace lib_aplicaciones.Interfaces
{
    public interface IPrestamosAplicacion
    {
        void Configurar(string string_conexion);
        List<Prestamos> Listar();
        List<Prestamos> Buscar(Prestamos entidad, string tipo);
        Prestamos Guardar(Prestamos entidad);
        Prestamos Modificar(Prestamos entidad);
        Prestamos Borrar(Prestamos entidad);
    }
}