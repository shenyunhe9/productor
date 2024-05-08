using EmailServices;
using IconfigServices;
using LogServices;
using Microsoft.Extensions.DependencyInjection;

namespace DITest

{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection service = new ServiceCollection();
            service.AddScoped<IconfigService, IconfigServiceImp>();
            service.AddScoped<LogProvider, LogServicesImp>();
            service.AddScoped<ImailService, ImailServiceImp>();
            using (var scope = service.BuildServiceProvider())
            {
                var mailService = scope.GetRequiredService<ImailService>();
                mailService.Send("hello","2415622259@qq,com","nihao");
            }
        }
    }
}
