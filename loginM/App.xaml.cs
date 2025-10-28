
namespace loginM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
        
            return window;
            
            window.Width = 400;
            window.Height = 600;
        }
    } // Fecha classe
} // Fecha namespace
