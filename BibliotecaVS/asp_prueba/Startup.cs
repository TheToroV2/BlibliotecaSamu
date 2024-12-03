using asp_prueba.Controllers;
using lib_aplicaciones.Implementaciones;
using lib_aplicaciones.Interfaces;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;
using Microsoft.AspNetCore.Server.Kestrel.Core;

namespace asp_prueba
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public static IConfiguration? Configuration { set; get; }

        public void ConfigureServices(WebApplicationBuilder builder, IServiceCollection services)
        {
            services.Configure<KestrelServerOptions>(x => { x.AllowSynchronousIO = true; });
            services.Configure<IISServerOptions>(x => { x.AllowSynchronousIO = true; });
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddScoped<Conexion, Conexion>();
            // Repositorios
            services.AddScoped<IDetallesRepositorio, DetallesRepositorio>();
            services.AddScoped<IEstadosRepositorio, EstadosRepositorio>();
            services.AddScoped<ILibrosRepositorio, LibrosRepositorio>();
            services.AddScoped<INotasRepositorio, NotasRepositorio>();
            services.AddScoped<IPersonasRepositorio, PersonasRepositorio>();
            services.AddScoped<IPrestamosRepositorio, PrestamosRepositorio>();
            services.AddScoped<IUsuariosRepositorio, UsuariosRepositorio>();
            // Aplicaciones
            services.AddScoped<IDetallesAplicacion, DetallesAplicacion>();
            services.AddScoped<IEstadosAplicacion, EstadosAplicacion>();
            services.AddScoped<ILibrosAplicacion, LibrosAplicacion>();
            services.AddScoped<INotasAplicacion, NotasAplicacion>();
            services.AddScoped<IPersonasAplicacion, PersonasAplicacion>();
            services.AddScoped<IPrestamosAplicacion, PrestamosAplicacion>();
            services.AddScoped<IUsuariosAplicacion, UsuariosAplicacion>();
            // Controladores
            services.AddScoped<TokenController, TokenController>();
            services.AddScoped<DetallesController, DetallesController>();

            services.AddCors(o => o.AddDefaultPolicy(b => b.AllowAnyOrigin()));
        }

        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            /*if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }*/
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
            app.UseRouting();
            app.UseCors();
        }
    }
}