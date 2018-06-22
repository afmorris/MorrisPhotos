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
            var dbFactory = new OrmLiteConnectionFactory(configuration.GetConnectionString("DefaultConnection"), SqlServerDialect.Provider);
            //var dbFactory = new OrmLiteConnectionFactory(":memory:", SqliteDialect.Provider);
            using (var db = dbFactory.Open())
            {
                db.DropTable<PersonPhoto>();
                db.DropTable<Photo>();
                db.DropTable<Person>();
                db.DropTable<PhotoEvent>();
                db.DropTable<Category>();
                db.DropTable<SchoolYear>();

                db.CreateTable<PhotoEvent>();
                db.CreateTable<Photo>();
                db.CreateTable<Person>();
                db.CreateTable<PersonPhoto>();
                db.CreateTable<Category>();
                db.CreateTable<SchoolYear>();

                db.InsertAll(SeedData.SchoolYearSeed.SchoolYears);
                db.InsertAll(SeedData.CategorySeed.Categories);
                db.InsertAll(SeedData.PhotoEventSeed.PhotoEvents);
                db.InsertAll(SeedData.Photo2016TrackSeed.TrackAndField2016Photos);
                db.InsertAll(SeedData.Photo2016XCSeed.CrossCountry2016Photos);
                db.InsertAll(SeedData.PersonSeed.People);
                db.InsertAll(SeedData.PersonPhotoSeed.PeoplePhotos);
            }

            return dbFactory;
        }
    }
}
