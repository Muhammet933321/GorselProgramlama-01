using System.Data.SQLite;
namespace GorselProgramlama_01
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new GirisEkraniForm());
        }
    }
}