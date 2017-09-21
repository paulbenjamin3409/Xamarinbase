
using Xamarin.Forms;

namespace Shared
{
    public class App : Application
    {
        public App()
        {
            MainPage = new Pages.BasicPage();
        }

        protected override void OnStart()
        {
            base.OnStart();
        }

        protected override void OnSleep()
        {
            base.OnSleep();
        }

        protected override void OnResume()
        {

        }
    }
}
