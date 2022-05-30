using System;
using Prism.DryIoc;
using Prism.Ioc;
using TestMenu.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestMenu
{
    //public partial class App : PrismApplication
    //{
    //    public App()
    //    {
    //    }

    //    protected override async void OnInitialized()
    //    {
    //        InitializeComponent();

    //        var result = await NavigationService.NavigateAsync("FirstPagePopup");

    //        if (!result.Success)
    //        {
    //            System.Diagnostics.Debugger.Break();
    //        }
    //    }

    //    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    //    {
    //        containerRegistry.RegisterForNavigation<NavigationPage>();
    //        containerRegistry.RegisterForNavigation<FirstPagePopup, FirstPageViewModel>();
    //        containerRegistry.RegisterForNavigation<SecondPagePopup, SecondPageViewModel>();
    //        containerRegistry.RegisterForNavigation<ThirdPagePopup, ThirdPageViewModel>();
    //        containerRegistry.RegisterForNavigation<FourthPagePopup, FourthPageViewModel>();
    //        containerRegistry.RegisterForNavigation<FivethPagePopup, FivethPageViewModel>();
    //    }

    //    protected override void OnStart()
    //    {
    //    }

    //    protected override void OnSleep()
    //    {
    //    }

    //    protected override void OnResume()
    //    {
    //    }
    //}

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new NavigationPage(new FirstPage());
            MainPage = new MainPage();
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
