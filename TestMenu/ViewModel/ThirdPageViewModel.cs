using System;
using System.Collections.ObjectModel;
using Prism.Commands;
using Prism.Navigation;

namespace TestMenu.ViewModel
{
    public class ThirdPageViewModel : BaseMultiLangPageViewModel
    {
        public DelegateCommand NextPage => new DelegateCommand(NextPageCommand);
        public DelegateCommand FirstPage => new DelegateCommand(FirstPageCommand);
        public DelegateCommand PreviousPage => new DelegateCommand(PreviousPageCommand);

        public ObservableCollection<User> Users { get; set; }

        public ThirdPageViewModel(INavigationService navigationService) : base(navigationService)
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

        public async void NextPageCommand()
        {
            await _navigationService.NavigateAsync("FourthPagePopup", animated: false);

        }public async void PreviousPageCommand()
        {
            await _navigationService.NavigateAsync("SecondPagePopup", animated: false);
        }

        public async void FirstPageCommand()
        {
            await _navigationService.NavigateAsync("FirstPagePopup", animated: false);
        }
    }
}
