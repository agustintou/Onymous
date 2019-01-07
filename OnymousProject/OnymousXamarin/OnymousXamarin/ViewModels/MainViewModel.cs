using System.Collections.ObjectModel;

namespace OnymousXamarin.ViewModels
{
    public class MainViewModel
    {
        #region Attributes

        #endregion

        #region Properties
        public ObservableCollection<MenuViewModel> Menu { get; set; }
        public ObservableCollection<MenuViewModel> MenuExit { get; set; }
        #endregion

        #region Builders
        public MainViewModel()
        {
            LoadMenu();
        }
        #endregion

        #region Commands

        #endregion

        #region Methods
        void LoadMenu()
        {
            Menu = new ObservableCollection<MenuViewModel>
            {
                new MenuViewModel
                {
                    Icon = @"user.png",
                    Navigation = @"PruebaPage",
                    Title = @"Prueba"
                },
            };

            MenuExit = new ObservableCollection<MenuViewModel>
            {
                new MenuViewModel
                {
                    Icon = @"user.png",
                    Navigation = @"PruebaPage",
                    Title = @"Exit"
                }
            };
        }
        #endregion
    }
}
