using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPopup : PopupPage
    {
        public class MenuItemModel
        {
            public uint Id { get; set; }
            public string Label { get; set; }
            public string IConText { get; set; }
            public object Tag { get; set; }
            public string RightText { get; set; }
            public string FunctionConstant { get; set; }
        }

        protected int ITEM_HEIGHT = 41;
        private MenuItemModel _selectedItem { get; set; }
        private bool _isShowRightofTriggerView { get; set; }
        private bool _isPreventDimissPopup { get; set; }

        protected CollectionView LvItems => lv_items;
        protected Frame FrameMenu => frameMenu;
        protected Label PopupTitle => popupTitle;

        public IList<MenuItemModel> MenuModelItems { get; set; }

        public Action<MenuItemModel> OnSelectedItem { get; set; }

        public MenuItemModel SelectedMenuItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                _selectedItem = value;
                HandleSelectedItemEventAsync();
            }
        }

        private async Task HandleSelectedItemEventAsync()
        {
            if (_selectedItem != null)
            {
                if (!_isPreventDimissPopup)
                {
                    await PopupNavigation.Instance.RemovePageAsync(this);
                }
                OnSelectedItem?.Invoke(_selectedItem);
            }
        }
        public string MenuTitle { get; protected set; }
        protected VisualElement _triggerView;
        public MenuPopup()
        {

            MenuTitle = "Menu";
            
            MenuModelItems = GetList();


            InitializeComponent();

        }

        protected void SetMenuHeight(IList<MenuItemModel> menuItems)
        {
            lv_items.HeightRequest = 800;
        }

        public List<MenuItemModel> GetList()
        {
            var result = new List<MenuItemModel>();
            for (int i = 0; i < 4; i++)
            {
                result.Add(new MenuItemModel()
                {
                    Label = "VVdd",
                    IConText = "drink.png"
                });
                result.Add(new MenuItemModel()
                {
                    Label = "Absadsjkhfasdjkfhajksdhflkddddd",
                    IConText = "drink2.png"
                });
                result.Add(new MenuItemModel()
                {
                    Label = "12131jksdhflkddddd",
                    IConText = "drink3.png"
                });
                result.Add(new MenuItemModel()
                {
                    Label = "12131jksdhflkddddd",
                    IConText = "ava.png"
                });
                result.Add(new MenuItemModel()
                {
                    Label = "aaaaa",
                    IConText = "ava2.png"
                });
                result.Add(new MenuItemModel()
                {
                    Label = "llllll",
                    IConText = "ava3.png"
                });
                result.Add(new MenuItemModel()
                {
                    Label = "sdfbb311",
                    IConText = "ava4.png"
                });
            }
            return result;
        }

        public void ShowItemMenu()
        {
            if (MenuModelItems != null && MenuModelItems.Any())
            {
                PopupNavigation.Instance.PushAsync(this);
                frameMenu.TranslationY = 10;
                if (!_isShowRightofTriggerView)
                {
                    frameMenu.TranslationX = 545 - frameMenu.WidthRequest;
                }
                else
                {
                    frameMenu.TranslationX = 545;
                }
            }
        }

        public async Task DismissAsync()
        {
            await PopupNavigation.Instance.RemovePageAsync(this);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            PopupNavigation.Instance.RemovePageAsync(this);
        }
    }
}
