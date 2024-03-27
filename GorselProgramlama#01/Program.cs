using System.Data.SQLite;
using System.Security.Cryptography.X509Certificates;
namespace GorselProgramlama_01
{
    public static class Program
    {
        

        [STAThread]
        public static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new MainMenuForm());
        }
    }
}