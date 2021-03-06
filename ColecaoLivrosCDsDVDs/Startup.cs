using ColecaoLivrosCDsDVDs.Context;
using ColecaoLivrosCDsDVDs.Context.CdContext;
using ColecaoLivrosCDsDVDs.Context.DvdContext;
using ColecaoLivrosCDsDVDs.Context.LivroContext;
using ColecaoLivrosCDsDVDs.Repository;
using ColecaoLivrosCDsDVDs.Repository.EmprestimoRepository;
using ColecaoLivrosCDsDVDs.Servico;
using ColecaoLivrosCDsDVDs.Servico.CDs;
using ColecaoLivrosCDsDVDs.Servico.DVDs;
using ColecaoLivrosCDsDVDs.Servico.Emprestimo;
using ColecaoLivrosCDsDVDs.Servico.Livros;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs
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
            services.AddControllersWithViews();

            services.AddScoped<IEmprestimoRepository, EmprestimoRepository>();
            services.AddScoped<IColecaoRepository, ColecaoRepository>();
            AddDependenciasContext(services);
            AddDependenciasServicos(services);
            services.AddScoped<AplicacaoContext>();
        }

        public void AddDependenciasServicos(IServiceCollection services)
        {
            services.AddScoped<IUsuarioServico, UsuarioServico>();
            services.AddScoped<ILivroServico, LivroServico>();
            services.AddScoped<ICdServico, CdServico>();
            services.AddScoped<IDvdServico, DvdServico>();
            services.AddScoped<IEmprestimoServico, EmprestimoServico>();
        }

        public void AddDependenciasContext(IServiceCollection services)
        {
            services.AddTransient<IUsuarioContext, UsuarioContext>();
            services.AddScoped<ILivroContext, LivroContext>();
            services.AddScoped<ICdContext, CdContext>();
            services.AddScoped<IDvdContext, DvdContext>();
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
