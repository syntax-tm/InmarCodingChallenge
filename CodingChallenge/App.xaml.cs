using System.Reflection;
using System.Windows;
using Autofac;

namespace CodingChallenge
{
    public partial class App
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            BootStrapper.Start();

            MainWindow = new MainWindow();
            MainWindow.Show();
        }
    }
}
