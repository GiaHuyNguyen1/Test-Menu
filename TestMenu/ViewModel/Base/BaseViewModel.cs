using System;
using System.Collections.Generic;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;

namespace TestMenu.ViewModel.Base
{
    public abstract class BaseViewModel : BindableBase, IInitialize, INavigatedAware
    {
        protected IPageDialogService _pageDialogService { get; }
        public INavigationService _navigationService { get; }

        protected virtual void OnBackResume()
        {

        }

        public string Title { get; }

        public IEnumerable<string> Messages { get; set; }

        public int InitializedCount { get; set; }

        public int OnNavigatedFromCount { get; set; }

        public int OnNavigatedToCount { get; set; }

        public DelegateCommand GoHomeCommand { get; }

        
        public DelegateCommand<string> NavigateCommand { get; }

        public virtual DelegateCommand NavigateLanguage => new DelegateCommand(async () =>
        {

        });

        public BaseViewModel(INavigationService navigationService, IPageDialogService pageDialogService = null)
        {
            _pageDialogService = pageDialogService;
            _navigationService = navigationService;

            GoHomeCommand = new DelegateCommand(OnGoHomeCommandExecuted);
            NavigateCommand = new DelegateCommand<string>(OnNavigateCommandExecuted);
        }


        private async void OnNavigateCommandExecuted(string path)
        {
            var result = await _navigationService.NavigateAsync(path);
            if (!result.Success)
            {
                System.Diagnostics.Debugger.Break();
            }
        }

        private async void OnGoHomeCommandExecuted()
        {
            var result = await _navigationService.NavigateAsync("/MainPage");
            if (!result.Success)
            {
                System.Diagnostics.Debugger.Break();
            }
        }

        public void Initialize(INavigationParameters parameters)
        {
            InitializedCount++;
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            OnNavigatedFromCount++;
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            OnNavigatedToCount++;
        }

        public virtual DelegateCommand OnBack => new DelegateCommand(() =>
        {
            _navigationService.GoBackAsync();
        });

        public delegate void ChangeLanguageAction();
        public event ChangeLanguageAction ChangeLanguageEvent;
    }
}
