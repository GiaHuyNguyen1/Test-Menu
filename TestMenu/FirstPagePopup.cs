using System;
namespace TestMenu
{
    public class FirstPagePopup : BaseMultilangContentPage
    {
        public FirstPagePopup()
        {
            this.Content = new FirstPage();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        protected override void SetupLandscapeLayout()
        {
            throw new NotImplementedException();
        }

        protected override void SetupPortraitLayout()
        {
            throw new NotImplementedException();
        }
    }
}
