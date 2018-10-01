using EquilibriumApp.Services;
using EquilibriumApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XLabs.Forms.Services;

namespace EquilibriumApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public string Email { get; set;}
        public string Password { get; set;}
        public ICommand LoginCmd { get; }

        readonly IFirebaseAuthenticator firebaseAuthenticator;
        readonly Services.NavigationService navigationService;

        Action propChangedCallBack => (LoginCmd as Command).ChangeCanExecute;

        public LoginViewModel(IFirebaseAuthenticator firebaseAuthenticator, Services.NavigationService navigationService)
        {
            this.firebaseAuthenticator = firebaseAuthenticator;
            this.navigationService = navigationService;

            LoginCmd = new Command(async () => await Login());
        }

        async Task Login()
        {
            IsBusy = true;
            propChangedCallBack();
            (Application.Current as App).AuthToken = await firebaseAuthenticator.LoginWithEmailPassword(Email, Password);
            await navigationService.PushAsync(new SelecaoDeInteresses());
            IsBusy = false;
            propChangedCallBack();
        }
    }
}
