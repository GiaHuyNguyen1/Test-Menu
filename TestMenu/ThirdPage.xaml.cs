using System;
using System.Collections.Generic;
using TestMenu.ViewModel;
using Xamarin.Forms;

namespace TestMenu
{
    public partial class ThirdPage : ContentView
    {
        public ThirdPage()
        {
            InitializeComponent();
        }

    }
    //public partial class ThirdPage : ContentPage
    //{
    //    public ThirdPage()
    //    {
    //        this.BindingContext = new FirstPageViewModel();
    //        InitializeComponent();
    //    }

    //    async void Button_Clicked(System.Object sender, System.EventArgs e)
    //    {
    //        await Navigation.PushAsync(new SecondPage());
    //    }

    //    async void Button_Clicked_1(System.Object sender, System.EventArgs e)
    //    {
    //        await Navigation.PushAsync(new FirstPage());
    //    }

    //    async void Button_Clicked_2(System.Object sender, System.EventArgs e)
    //    {
    //        await Navigation.PushAsync(new FourdPage());
    //    }
    //}
}
