using System;
using System.Collections.ObjectModel;
using Prism.Commands;
using Prism.Navigation;

namespace TestMenu.ViewModel
{
    public class FivethPageViewModel: BaseMultiLangPageViewModel
    {
        public DelegateCommand PreviousPage => new DelegateCommand(PreviousPageCommand);
        public DelegateCommand FirstPage => new DelegateCommand(FirstPageCommand);
        public DelegateCommand SecondPage => new DelegateCommand(SecondPageCommand);
        public DelegateCommand ThirdPage => new DelegateCommand(ThirdPageCommand);
        public DelegateCommand FourthPage => new DelegateCommand(FourthPageCommand);
        public ObservableCollection<User> Users { get; set; }

        public FivethPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            var DataSource = new ObservableCollection<User>();

            for (int i = 0; i < 20; i++)
            {
                User user = new User();
                user.Name = "Tocotoco";
                user.Image = "drink.png";
                DataSource.Add(user);
            }

            Users = DataSource;
        }

        public async void PreviousPageCommand()
        {
            await _navigationService.NavigateAsync("FourthPagePopup", animated: false);
        }

        public async void FirstPageCommand()
        {
            await _navigationService.NavigateAsync("FirstPagePopup", animated: false);
        }

        public async void SecondPageCommand()
        {
            await _navigationService.NavigateAsync("SecondPagePopup", animated: false);
        }

        public async void ThirdPageCommand()
        {
            await _navigationService.NavigateAsync("ThirdPagePopup", animated: false);
        }

        public async void FourthPageCommand()
        {
            await _navigationService.NavigateAsync("FourthPagePopup", animated: false);
        }
    }
}
