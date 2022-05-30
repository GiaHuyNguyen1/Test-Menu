using System;
using Xamarin.Forms;

namespace TestMenu
{
    public abstract class BaseContentPage: ContentPage
    {
        public BaseContentPage()
        {
        }

        protected virtual void OnBackResume()
        {

        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
        }
        protected abstract void SetupLandscapeLayout();
        protected abstract void SetupPortraitLayout();

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

    }
}
