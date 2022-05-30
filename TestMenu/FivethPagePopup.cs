using System;
namespace TestMenu
{
    public class FivethPagePopup : BaseMultilangContentPage
    {
        public FivethPagePopup()
        {
            this.Content = new FivePage();
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
