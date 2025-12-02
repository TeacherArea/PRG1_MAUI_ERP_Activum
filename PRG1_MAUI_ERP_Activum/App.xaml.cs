using Microsoft.Extensions.DependencyInjection;

namespace PRG1_MAUI_ERP_Activum
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            const double width = 400;
            const double height = 800;
            return new Window(new AppShell())
            {
                Width = width,
                Height = height
            };
        }
    }
}