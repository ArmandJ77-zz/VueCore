using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Nancy;
using Nancy.Owin;
using VueCore.Infrastructure;

//using VueCore.Infrastructure.Bootstrapper;

namespace VueCore
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
      services.AddMvc();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
    {

      loggerFactory.AddConsole(Configuration.GetSection("Logging"));
      loggerFactory.AddDebug();

      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
        app.UseBrowserLink();
        // Setup WebpackDevMidleware for "Hot module replacement" while debugging

        app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
          { HotModuleReplacement = true });
      }
      else
      {
        app.UseExceptionHandler("/Home/Error");
      }

      app.UseStaticFiles();
      app.UseOwin(x => x.UseNancy(options =>
      {
        options.Bootstrapper = new AppNancyBootstrapper(env);
        options.PassThroughWhenStatusCodesAre(
          HttpStatusCode.NotFound,
          HttpStatusCode.InternalServerError
          );
      }));

      app.UseMvc(routes =>
      {
        routes.MapRoute(
          name: "default",
          template: "{controller=Home}/{action=Index}/{id?}");

        // Setup additional routing for SPA
        routes.MapSpaFallbackRoute(
          name: "spa-fallback",
          defaults: new { controller = "Home", action = "Index" });
      });
    }
  }
}
