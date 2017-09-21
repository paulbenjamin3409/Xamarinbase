using Android.App;
using Android.Widget;
using Android.OS;
using Shared;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace Droid
{
    [Activity(Label = "Xamarin Base", MainLauncher = true)]
    public class MainActivity : FormsApplicationActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Forms.Init(this, savedInstanceState);

            LoadApplication(new App());

        }
    }
}

