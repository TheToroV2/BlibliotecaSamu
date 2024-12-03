using lib_comunicaciones.Implementaciones;
using lib_comunicaciones.Interfaces;
using lib_presentaciones.Implementaciones;
using lib_presentaciones.Interfaces;

namespace asp_presentacion
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
            // Comunicaciones
            services.AddScoped<IDetallesComunicacion, DetallesComunicacion>();
            services.AddScoped<IEstadosComunicacion, EstadosComunicacion>();
            services.AddScoped<ILibrosComunicacion, LibrosComunicacion>();
            services.AddScoped<INotasComunicacion, NotasComunicacion>();
            services.AddScoped<IPersonasComunicacion, PersonasComunicacion>();
            services.AddScoped<IPrestamosComunicacion, PrestamosComunicacion>();
            services.AddScoped<IUsuariosComunicacion, UsuariosComunicacion>();
            // Presentaciones
            services.AddScoped<IDetallesPresentacion, DetallesPresentacion>();
            services.AddScoped<IEstadosPresentacion, EstadosPresentacion>();
            services.AddScoped<ILibrosPresentacion, LibrosPresentacion>();
            services.AddScoped<INotasPresentacion, NotasPresentacion>();
            services.AddScoped<IPersonasPresentacion, PersonasPresentacion>();
            services.AddScoped<IPersonasPresentacion, PersonasPresentacion>();
            services.AddScoped<IPrestamosPresentacion, PrestamosPresentacion>();
            services.AddScoped<IUsuariosPresentacion, UsuariosPresentacion>();

            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddRazorPages();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });
        }

        public void Configure(WebApplication app, IWebHostEnvironment env)
        {

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.MapRazorPages();
            app.UseSession();
            app.Run();
        }
    }
}