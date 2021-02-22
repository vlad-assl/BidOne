using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using BidOne.TechnicalTask.Lib.Repositories.Interfaces;
using BidOne.TechnicalTask.Lib.Repositories;
using BidOne.TechnicalTask.Lib.Services.Interfaces;
using BidOne.TechnicalTask.Lib.Services;



namespace BidOne.TechincalTask
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
            

            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddTransient<IFileRepository, FileRepository>();
            services.AddTransient<IWriteJsonToFileService, WriteJsonToFileService>();
        }
       
    }
}