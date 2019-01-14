namespace OnymousMobile.ViewModels
{
    public class MainViewModel
    {
        #region Attributes

        #endregion

        #region Properties
        public CreateAccountViewModel CreateAccountVM { get; set; }
        #endregion

        #region Builders
        public MainViewModel()
        {
            CreateAccountVM = new CreateAccountViewModel();
        }
        #endregion

        #region Commands

        #endregion

        #region Methods

        #endregion
    }
}
