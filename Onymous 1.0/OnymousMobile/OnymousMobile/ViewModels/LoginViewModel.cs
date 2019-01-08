using GalaSoft.MvvmLight.Command;
using OnymousMobile.Models;
using System.Windows.Input;

namespace OnymousMobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region Attributes
        private User _user { get; set; }
        public User User
        {
            get
            {
                return this._user;
            }
            set
            {
                if(value != _user)
                {
                    _user = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _message { get; set; }
        public string Message
        {
            get
            {
                return this._message;
            }
            set
            {
                if (value != _message)
                {
                    _message = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Properties
        public ICommand CommandLogin { get { return new RelayCommand(LoginC); } }

        public ICommand CommandLoginFacebook { get { return new RelayCommand(LoginFacebookC); } }

        public ICommand CommandLoginInstagram { get { return new RelayCommand(LoginInstagramC); } }

        public ICommand CommandLoginAnonymous { get { return new RelayCommand(LoginAnonymousC); } }
        #endregion

        #region Builders
        public LoginViewModel()
        {
            InitialData();
        }
        #endregion

        #region Commands
        void LoginC()
        {

        }

        void LoginFacebookC()
        {

        }

        void LoginInstagramC()
        {

        }

        void LoginAnonymousC()
        {

        }
        #endregion

        #region Methods
        void InitialData()
        {
            User = new User();
        }
        #endregion
    }
}
