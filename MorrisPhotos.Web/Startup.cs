using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MorrisPhotos.Web.DataModels;
using ServiceStack;
using ServiceStack.Data;
using ServiceStack.OrmLite;

namespace MorrisPhotos.Web
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
            services.AddSingleton(SetupDatabase(this.Configuration));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseServiceStack(new AppHost
            {
                AppSettings = new NetCoreAppSettings(Configuration)
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private IDbConnectionFactory SetupDatabase(IConfiguration configuration)
        {
            //var dbFactory = new OrmLiteConnectionFactory(this.Configuration.GetConnectionString("DefaultConnection"), SqlServerDialect.Provider);
            var dbFactory = new OrmLiteConnectionFactory(":memory:", SqliteDialect.Provider);
            using (var db = dbFactory.Open())
            {
                db.DropAndCreateTable<Photo>();
                db.DropAndCreateTable<PhotoEvent>();
                db.DropAndCreateTable<Category>();
                db.DropAndCreateTable<SchoolYear>();
                db.DropAndCreateTable<Person>();

                db.InsertAll(SeedData.SchoolYears);
                db.InsertAll(SeedData.Categories);
                db.InsertAll(SeedData.PhotoEvents);
                db.InsertAll(SeedData.Photos);
                db.InsertAll(SeedData.People);

                //if (db.CreateTableIfNotExists<SchoolYear>())
                //{
                //}

                //if (db.CreateTableIfNotExists<Category>())
                //{
                //}

                //if (db.CreateTableIfNotExists<Person>())
                //{
                //}

                //if (db.CreateTableIfNotExists<Photo>())
                //{
                //}

                //if (db.CreateTableIfNotExists<PhotoEvent>())
                //{
                //}
            }

            return dbFactory;
        }
    }
}
