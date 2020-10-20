using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Blog.Article.Business.Abstract.Services;
using Blog.Article.Business.Concrete.Managers;
using Blog.Article.DataAccess.Abstract;
using Blog.Article.DataAccess.Concrete;
using Blog.Article.DataAccess.Concrete.Contexts;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Blog.Article.WebApi
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
            services.AddAutoMapper();
            services.AddControllers().AddNewtonsoftJson(opt=>
            {
                opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            }).AddFluentValidation(options => { options.RegisterValidatorsFromAssemblyContaining<Startup>(); });

            services.AddScoped<IArticleDal, EfArticleDal>();
            services.AddScoped<IArticleServices, ArticleManager>();
            services.AddScoped<IQueryableRepo<Article.Entities.Concrete.Article>, EfQueryableRepo<Article.Entities.Concrete.Article>>();

            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<ICategoryService,CategoryManager>();

            services.AddScoped<ArticleContext, ArticleContext>();
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
