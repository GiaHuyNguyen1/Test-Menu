using System;
using System.Collections.ObjectModel;

namespace TestMenu
{
    public class User
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
    }

    public class MainPageViewModel
    {
        public ObservableCollection<User> Users { get; set; }
        public ObservableCollection<User> Product { get; set; }

        public MainPageViewModel()
        {
            var DataSource = new ObservableCollection<User>();
            var DataSource2 = new ObservableCollection<User>();

            for (int i = 0; i < 30; i++)
            {
                User user = new User();
                user.Name = "Tocotoco";
                user.Image = "drink.png";
                DataSource.Add(user);

                User user2 = new User();
                user.Name = "Tocotoco";
                user.Image = "drink2.png";
                DataSource.Add(user2);

                User user3 = new User();
                user.Name = "Tocotoco";
                user.Image = "drink3.png";
                DataSource.Add(user3);
            }
            Users = DataSource;

            for (int i = 0; i < 30; i++)
            {
                User user = new User();
                user.Name = "Tocotoco 2";
                user.Image = "drink2.png";
                DataSource2.Add(user);

                User user2 = new User();
                user.Name = "Tocotoco 2";
                user.Image = "drink3.png";
                DataSource2.Add(user2);

                User user3 = new User();
                user.Name = "Tocotoco 2";
                user.Image = "ava.png";
                DataSource2.Add(user3);
            }
            Product = DataSource2;
        }
    }
}
