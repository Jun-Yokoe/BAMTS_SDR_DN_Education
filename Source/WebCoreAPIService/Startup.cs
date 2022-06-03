using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreAPIService
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
            //services.AddCors(); //���ǉ��i�������������₯�ǁA�l�b�g���[�N�z���ɃA�N�Z�X�����ꍇ�ɕK�v�j��
            services.AddCors(options =>
                options.AddDefaultPolicy(builder =>
                {
                    //builder.WithOrigins("http://192.168.1.12:1487").AllowAnyMethod().AllowAnyHeader();
                    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                })
            ); //���ǉ��i�������������₯�ǁA�l�b�g���[�N�z���ɃA�N�Z�X�����ꍇ�ɕK�v�j��
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebCoreAPIService", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebCoreAPIService v1"));
            }

            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()); //���ǉ��i�������������₯�ǁA�l�b�g���[�N�z���ɃA�N�Z�X�����ꍇ�ɕK�v�j��
            //app.UseCors(); //���ǉ��i�������������₯�ǁA�l�b�g���[�N�z���ɃA�N�Z�X�����ꍇ�ɕK�v�j��

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
