using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StylistPro.Feedback.Application.Services;
using StylistPro.Feedback.Data.AppData;
using StylistPro.Feedback.Data.Repositories;
using StylistPro.Feedback.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace StylistPro.Feedback.IoC
{
    public static class Bootstrap
    {
        public static void Start(IServiceCollection services, IConfiguration configuration)
            
        {
            services.AddDbContext<ApplicationContext>(options => {
                options.UseOracle(configuration["ConnectionStrings:Oracle"]);
            });

            services.AddTransient<IFeedbackRepository, FeedbackRepository>();
            services.AddTransient<IFeedbackApplicationService, FeedbackApplicationService>();
        }
    }
}
