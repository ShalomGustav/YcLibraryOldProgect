using System.Threading.Tasks;

namespace YcLibrary.Interfaces
{
    public interface IYcTranslateService
    {
        Task<string> Translate(string source);
        Task<string> DetectLanguage(string source);
    }
}
