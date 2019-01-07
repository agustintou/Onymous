using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace OnymousXamarin.ViewModels
{
    public class WelcomeViewModel : BaseViewModel
    {
        #region Attributes

        #endregion

        #region Properties
        public ICommand CommandClose { get { return new RelayCommand(CloseC); } }

        public ICommand CommandCreateAccount { get { return new RelayCommand(CreateAccountC); } }

        public ICommand CommandLogin { get { return new RelayCommand(LoginC); } }
        #endregion

        #region Builders
        public WelcomeViewModel()
        {

        }
        #endregion

        #region Commands
        void CloseC()
        {

        }

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
