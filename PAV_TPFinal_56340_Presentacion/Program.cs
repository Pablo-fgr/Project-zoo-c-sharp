using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PAV_TPFinal_56340_Dominio.Repositorios;
using PAV_TPFinal_56340_Infraestructura_Datos;
using PAV_TPFinal_56340_Infraestructura_Datos.Repositorios;
using PAV_TPFinal_56340_Infraestructura_Transversal;
using PAV_TPFinal_56340_Presentacion.Interfaces;
using PAV_TPFinal_56340_Presentacion.Presentadores;
using PAV_TPFinal_56340_Presentacion.Tareas;
using PAV_TPFinal_56340_Presentacion.Vistas;

namespace PAV_TPFinal_56340_Presentacion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var service = new ServiceCollection();
            service
                .AddDbContext<PavTpFinalContext>(options =>
                {
                    options.UseSqlServer(PavTpFinalContext.CadenaDeConexion);
                })
                .AddSingleton<Navigator>()
                .AddTransient<IPrincipalView, PrincipalView>()
                .AddTransient<IZoologicoView, ZoologicoView>()
                .AddTransient<IAgregarAnimalView, AgregarAnimalView>()
                .AddTransient<ISectorView, SectorView>()
                .AddTransient<IRepositorio, Repositorio>()
                .AddTransient<PrincipalPresenter>()
                .AddTransient<ZoologicoPresenter>()
                .AddTransient<AgregarAnimalPresenter>()
                .AddTransient<SectorPresenter>()
                .AddScoped<ZoologicoTarea>();

                
            using var serviceProvider = service.BuildServiceProvider();
            Factoria.Instance.SetContenedor(serviceProvider);
            AdministradorDeTareas.Instance.Iniciar<ZoologicoTarea>();
            Application.Run(Application.OpenForms[0]!);

        }
    }
}