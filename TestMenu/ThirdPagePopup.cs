using System;
namespace TestMenu
{
    public class ThirdPagePopup : BaseMultilangContentPage
    {
        public ThirdPagePopup()
        {
            this.Content = new ThirdPage();
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
