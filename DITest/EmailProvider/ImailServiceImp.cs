using IconfigServices;
using LogServices;

namespace EmailServices
{
    public class ImailServiceImp : ImailService
    {
        private readonly LogProvider logProvider;
        private readonly IconfigService iconfigService;

        public ImailServiceImp(LogProvider logProvider, IconfigService iconfigService)
        {
            this.logProvider = logProvider;
            this.iconfigService = iconfigService;
        }

        public void Send(string title, string to, string body)
        {
            this.logProvider.LoggInfo("发送邮件");
            Console.WriteLine($"发送邮件成功{title}{to}");
            String username = this.iconfigService.getValue("username");
            String password = this.iconfigService.getValue("password");
            String url = this.iconfigService.getValue("url");
            Console.WriteLine($"{username}{password}{title}");
            this.logProvider.LoggInfo("邮件发送完成");
        }
    }
}
