
namespace plik
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

      //      MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window();

            window.MaximumHeight = 800;
            window.MinimumHeight = 800;
            window.MaximumWidth = 700;
            window.MinimumHeight = 700;

            window.Page = new AppShell();

            return window;
        }
    }
}
