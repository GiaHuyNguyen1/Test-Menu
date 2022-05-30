using System;
using System.Windows.Input;
using Prism.Commands;
using Prism.Navigation;
using Xamarin.Forms;

namespace TestMenu.ViewModel
{
    public class StartContentPageViewModel: BaseMultiLangPageViewModel
    {
        public bool IsClaimDevice { get; set; }

        public string CloudManager { get; set; }
        public string ClaimDevice { get; set; }
        public string LoginCloud { get; set; }
        public string Start { get; set; }

        public DelegateCommand StartActivity => new DelegateCommand(OnStart);

        private void OnStart()
        {
            throw new NotImplementedException();
        }

        public DelegateCommand ClaimDatabase => new DelegateCommand(OnClaimDatabase);

        private void OnClaimDatabase()
        {
            throw new NotImplementedException();
        }

        public ICommand MenuTapped => new Command<object>(OnMenuTapped);

        private void OnMenuTapped(object obj)
        {
            throw new NotImplementedException();
        }

        public StartContentPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}
