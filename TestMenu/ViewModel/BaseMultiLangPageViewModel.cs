using System;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using TestMenu.ViewModel.Base;

namespace TestMenu.ViewModel
{
    public class BaseMultiLangPageViewModel: BaseViewModel
    {
        public BaseMultiLangPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService = null) : base(navigationService, pageDialogService)
        {
        }

    }
}
