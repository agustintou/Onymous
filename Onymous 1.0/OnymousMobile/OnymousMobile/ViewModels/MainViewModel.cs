namespace OnymousMobile.ViewModels
{
    public class MainViewModel
    {
        #region Attributes

        #endregion

        #region Properties
        public CreateAccountViewModel CreateAccountVM { get; set; }

        public MyProfileViewModel MyProfileVM { get; set; }
        #endregion

        #region Builders
        public MainViewModel()
        {
            CreateAccountVM = new CreateAccountViewModel();
            MyProfileVM = new MyProfileViewModel();
        }
        #endregion

        #region Commands

        #endregion

        #region Methods

        #endregion
    }
}
