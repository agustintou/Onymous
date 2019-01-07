using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace OnymousMobile.ViewModels
{
    public class WelcomeViewModel : BaseViewModel
    {
        #region Attributes

        #endregion

        #region Properties
        public ICommand CommandLogin { get { return new RelayCommand(LoginC); }  }

        public ICommand CommandCreateAccount { get { return new RelayCommand(CreateAccountC); } }
        #endregion

        #region Builders
        public WelcomeViewModel()
        {

        }
        #endregion

        #region Commands
        void LoginC()
        {

        }

        void CreateAccountC()
        {

        }
        #endregion

        #region Methods

        #endregion
    }
}
