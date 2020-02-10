using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LojaVirtual
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
            app.UseDefaultFiles(); // UseDefaultFiles tem que ficar antes de UseStaticFiles
            app.UseStaticFiles();
            app.UseCookiePolicy();

            /* https://www.site.com.br -> Qual controlador (o controlador faz a gestão)? Quem define são as rotas
             * https://www.site.com.br/Controller/Action/?id
             * Exemplo: https://www.site.com.br/Produto/Visualizar/102
             * Exemplo: https://www.site.com.br/Produto/Visualizar/MouseRazorZK (nome em vez de id)
             * Exemplo: https://www.site.com.br/Produto/Visualizar/ (listagem de todos os produtos, por exemplo)
             * 
             * https://www.site.com.br/ = https://www.site.com.br/Home/ = https://www.site.com.br/Home/Index/
             * https://www.site.com.br/Produto/ = https://www.site.com.br/Produto/Index
             */

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
