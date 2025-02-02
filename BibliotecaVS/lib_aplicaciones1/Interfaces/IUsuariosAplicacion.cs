﻿using lib_entidades.Modelos;
namespace lib_aplicaciones.Interfaces
{
    public interface IUsuariosAplicacion
    {
        void Configurar(string string_conexion);
        List<Usuarios> Listar();
        List<Usuarios> Buscar(Usuarios entidad, string tipo);
        Usuarios Guardar(Usuarios entidad);
        Usuarios Modificar(Usuarios entidad);
        Usuarios Borrar(Usuarios entidad);
    }
}