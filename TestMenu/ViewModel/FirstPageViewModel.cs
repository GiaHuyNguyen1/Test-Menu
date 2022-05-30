using System;
using System.Collections.ObjectModel;
using Prism.Commands;
using Prism.Navigation;
using Xamarin.Forms;

namespace TestMenu.ViewModel
{
    public class FirstPageViewModel : BaseMultiLangPageViewModel
    {
        public ObservableCollection<User> Users { get; set; }

        public DelegateCommand NextPage => new DelegateCommand(NextPageCommand);
        public DelegateCommand ThirdPage => new DelegateCommand(ThirdPageCommand);

        public FirstPageViewModel(INavigationService navigationService) : base(navigationService)
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
            await _navigationService.NavigateAsync("SecondPagePopup", animated: false);
        }

        public async void ThirdPageCommand()
        {
            await _navigationService.NavigateAsync("ThirdPagePopup", animated: false);
        }
    }

    //public class FirstPageViewModel
    //{
    //    public ObservableCollection<User> Users { get; set; }

    //    public FirstPageViewModel()
    //    {
    //        var DataSource = new ObservableCollection<User>();

    //        for (int i = 0; i < 20; i++)
    //        {
    //            User user = new User();
    //            user.Name = "Tocotoco";
    //            user.Image = "drink.png";
    //            DataSource.Add(user);
    //        }

    //        Users = DataSource;
    //    }
    //}
}
