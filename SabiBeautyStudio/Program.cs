using SabiBeautyStudio.config;
using SabiBeautyStudio.forms;

namespace SabiBeautyStudio
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataBaseConfig.getInstance();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
