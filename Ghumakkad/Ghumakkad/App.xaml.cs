using Ghumakkad.ViewModels;
using Ghumakkad.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Forms;

namespace Ghumakkad
{
    public partial class App 
    {
        public App() : this(null) { }
        public App(IPlatformInitializer initializer) : base(initializer) { }
        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(LoginPage)}");
             //await NavigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(AppTabPage)}");
            //await NavigationService.NavigateAsync($"{nameof(AppTabPage)}");
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            //Authentication Pages
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<SignUpPage, SignUpPageViewModel>();
            //App Pages
            containerRegistry.RegisterForNavigation<EventTimelinePage, EventTimelinePageViewModel>();
            containerRegistry.RegisterForNavigation<MonthPinsPage, MonthPinsPageViewModel>();
            containerRegistry.RegisterForNavigation<AppTabPage, AppTabPageViewModel>();
            containerRegistry.RegisterForNavigation<GhumakkadPage, GhumakkadPageViewModel>();

        }
        protected override void OnStart()
        {
        }
        protected override void OnSleep()
        {
        }
        protected override void OnResume()
        {
        }
    }
}
