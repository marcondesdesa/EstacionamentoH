using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using EstacionamentoH.MVC.AutoMapper;
using EstacionamentoH.Domain.Interfaces.Services;
using EstacionamentoH.Application.Interfaces;
using EstacionamentoH.Domain.Interfaces.Repositories;
using EstacionamentoH.Domain.Services;
using EstacionamentoH.Infra.Data.Repositories;
using EstacionamentoH.Application;
using System.Globalization;

namespace EstacionamentoH.MVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-BR");

            services.AddControllersWithViews();
            AutoMapperConfig.RegisterMappings();

            services.AddScoped(typeof(IAppServiceBase<>), typeof(AppServiceBase<>));

            //services.AddScoped<IAppServiceBase<T>, AppServiceBase<T>>();
            services.AddScoped<ICondutorAppService, CondutorAppService>();
            services.AddScoped<IEstacionamentoAppService, EstacionamentoAppService>();
            services.AddScoped<IParametroAppService, ParametroAppService>();
            services.AddScoped<IPrecoAppService, PrecoAppService>();
            services.AddScoped<IVeiculoAppService, VeiculoAppService>();

            services.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));
            //services.AddScoped<IServiceBase<T>, ServiceBase<T>>();
            services.AddScoped<ICondutorService, CondutorService>();
            services.AddScoped<IEstacionamentoService, EstacionamentoService>();
            services.AddScoped<IParametroService, ParametroService>();
            services.AddScoped<IPrecoService, PrecoService>();
            services.AddScoped<IVeiculoService, VeiculoService>();

            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            //services.AddScoped<IRepositoryBase<T>, RepositoryBase<T>>();
            services.AddScoped<ICondutorRepository, CondutorRepository>();
            services.AddScoped<IEstacionamentoRepository, EstacionamentoRepository>();
            services.AddScoped<IParametroRepository, ParametroRepository>();
            services.AddScoped<IPrecoRepository, PrecoRepository>();
            services.AddScoped<IVeiculoRepository, VeiculoRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Condutores/Index");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Condutores}/{action=Index}/{id?}");
            });
        }
    }
}
