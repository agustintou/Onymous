using GalaSoft.MvvmLight.Command;
using OnymousXamarin.Models;
using System.Windows.Input;

namespace OnymousXamarin.ViewModels
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
        #endregion

        #region Properties
        public ICommand CommandReturnRegister { get { return new RelayCommand(ReturnRegisterC); } }

        public ICommand CommandFacebook { get { return new RelayCommand(FacebookC); } }

        public ICommand CommandInstagram { get { return new RelayCommand(InstagramC); } }
        #endregion

        #region Builders
        public LoginViewModel()
        {
            InitialData();
        }
        #endregion

        #region Commands
        void ReturnRegisterC()
        {

        }
        
        void FacebookC()
        {

        }

        void InstagramC()
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
