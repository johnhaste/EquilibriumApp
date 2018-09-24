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
	public partial class SelecaoDeInteresses : ContentPage
	{
		public SelecaoDeInteresses ()
		{
			InitializeComponent ();
		}

        public async void Alert(object sender, EventArgs args)
        {
            await DisplayAlert("Teste", "Teste de abertura de alert", "Yes", "No");
        }
	}
}