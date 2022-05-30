using System;
namespace TestMenu
{
    public class SecondPagePopup : BaseMultilangContentPage
    {
        public SecondPagePopup()
        {
            this.Content = new SecondPage();
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
