using Microsoft.Extensions.DependencyInjection;

namespace AnthonySloat_CITA255MidtermProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}