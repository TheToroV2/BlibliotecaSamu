using lib_entidades.Modelos;
namespace lib_aplicaciones.Interfaces
{
    public interface INotasAplicacion
    {
        void Configurar(string string_conexion);
        List<Notas> Listar();
        List<Notas> Buscar(Notas entidad, string tipo);
        Notas Guardar(Notas entidad);
        Notas Modificar(Notas entidad);
        Notas Borrar(Notas entidad);
    }
}