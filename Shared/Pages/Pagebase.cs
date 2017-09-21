using System.Reactive.Disposables;
using Xamarin.Forms;

namespace Shared.Pages
{
    public class PageBase :ContentPage
    {
        protected readonly CompositeDisposable SubscriptionDisposables = new CompositeDisposable();

        public PageBase()
        {
            SetupUserInterface();

            SetupReactiveObservables();
        }

        protected virtual void SetupUserInterface() { }

        protected virtual void SetupReactiveObservables() { }

        protected virtual void SetupReactiveSubscriptions() { }

        protected override void OnAppearing()
        {
            SetupReactiveSubscriptions();

            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            SubscriptionDisposables.Clear();

            base.OnDisappearing();
        }
    }
}
