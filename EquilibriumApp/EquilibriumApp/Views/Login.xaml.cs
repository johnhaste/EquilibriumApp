using Autofac;
using EquilibriumApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EquilibriumApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            this.BindingContext = (Application.Current as App).Container.Resolve<LoginViewModel>();
        }

        async void IrParaCadastroPage(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Cadastro());
        }

        async void IrParaRecuperarSenhaPage(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new RecuperarSenha());
        }
        /*
        async void IrParaSelecaoDeInteresses(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SelecaoDeInteresses());
        }*/
    }
}