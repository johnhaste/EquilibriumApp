
using Android.App;
using Android.Content.PM;
using Android.OS;
using Firebase;

namespace EquilibriumApp.Droid
{
    [Activity(Label = "EquilibriumApp", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            FirebaseApp.InitializeApp(Application.Context);
            LoadApplication(new App());
        }
    }
}

