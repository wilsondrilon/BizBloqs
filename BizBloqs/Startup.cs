using BizBloqs.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using BizBloqs.Core;
using AutoMapper;
using BizBloqs.Core._Helper;
using System;
using BizBloqs.Core.ExternalDependency;

namespace BizBloqs
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            var d = env.EnvironmentName;
            var builder = new ConfigurationBuilder()
             .SetBasePath(env.ContentRootPath)
             .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
             .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
             .AddEnvironmentVariables();
            configuration = builder.Build();
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<BizBloqsContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:BizBloqConString"], builder =>
            {
                //builder.EnableRetryOnFailure();
            }));

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<IBizBloqsContext, BizBloqsContext>();
            services.AddScoped<IStoreTextData, StoreTextData>();
            services.AddScoped<IStoreTextCore, StoreTextCore>();
            services.AddScoped<IGeneralResponse, GeneralResponse>();
            services.AddScoped<IBizBloqsContext, BizBloqsContext>();
            services.AddScoped<IBizBloqsManager, BizBloqsManager>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
