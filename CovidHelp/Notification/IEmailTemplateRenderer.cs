using System.Threading.Tasks;

namespace CovidHelp.Notification
{
    public interface IEmailTemplateRenderer
    {
        Task<string> RenderAsync<T>(string templateName, T model);
    }
}
