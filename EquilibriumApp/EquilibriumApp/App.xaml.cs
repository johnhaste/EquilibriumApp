using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EquilibriumApp.Services;
using EquilibriumApp.ViewModels;
using EquilibriumApp.Views;
using Autofac;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace EquilibriumApp
{
    public partial class App : Application
	{
        public string AuthToken { get; set; }
        public IContainer Container { get; }

        public App ()
		{
			InitializeComponent();


            MainPage = new NavigationPage(new EquilibriumApp.Views.Login());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

        IContainer BuildContainer(Module module)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<LoginViewModel>().AsSelf();
            builder.RegisterType<NavigationService>().AsSelf().SingleInstance();
            builder.RegisterModule(module);
            return builder.Build();
        }
    }
}
