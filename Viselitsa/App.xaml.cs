using Microsoft.Extensions.DependencyInjection;
using Viselitsa.View.Pages;

namespace Viselitsa
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(GamePage), typeof(GamePage));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(GameWin), typeof(GameWin));
            Routing.RegisterRoute(nameof(GameOver), typeof(GameOver));
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}