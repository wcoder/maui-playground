using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;

using Application = Microsoft.Maui.Controls.Application;

using MauiApp1.Pages;
using MauiApp1.ViewModels;

namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage(new MainPageViewModel());
        }
    }
}
