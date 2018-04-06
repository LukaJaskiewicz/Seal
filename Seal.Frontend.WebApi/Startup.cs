using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Seal.Backend.DAL.DataContext;
using AutoMapper;
using Seal.Common.Dependiencies.Mappings;
using Microsoft.EntityFrameworkCore;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Seal.Common.Dependiencies.DI;

namespace Seal.Frontend.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public IContainer ApplicationContainer { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddAutoMapper(cfg => {
                cfg.AddProfile(new TemplateProfile());
            });

            var connection = @"Server=(local);Database=SEAL.Main;Trusted_Connection=True;";

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connection));

            var builder = new ContainerBuilder();
            builder.RegisterModule(new ContextHandlerModule());
            builder.RegisterModule(new ServicesHandlerModule());
            builder.RegisterModule(new RepositoryHandlerModule());
            builder.Populate(services);
            this.ApplicationContainer = builder.Build();

            return new AutofacServiceProvider(this.ApplicationContainer);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
