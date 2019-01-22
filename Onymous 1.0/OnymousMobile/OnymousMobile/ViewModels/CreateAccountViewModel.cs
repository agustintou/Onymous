using GalaSoft.MvvmLight.Command;
using OnymousMobile.Models;
using System.Windows.Input;

namespace OnymousMobile.ViewModels
{
    public class CreateAccountViewModel : BaseViewModel
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
                    CheckUser();
                }
            }
        }

        private Person _person { get; set; }
        public Person Person
        {
            get
            {
                return this._person;
            }
            set
            {
                if (value != _person)
                {
                    _person = value;
                    OnPropertyChanged();
                    CheckPerson();
                }
            }
        }

        private string _sourceImage { get; set; }
        public string SourceImage
        {
            get
            {
                return this._sourceImage;
            }
            set
            {
                if (value != _sourceImage)
                {
                    _sourceImage = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _carouselPosition { get; set; }
        public int CarouselPosition
        {
            get
            {
                return this._carouselPosition;
            }
            set
            {
                if (value != _carouselPosition)
                {
                    _carouselPosition = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isEnabledNext { get; set; }
        public bool IsEnabledNext
        {
            get
            {
                return this._isEnabledNext;
            }
            set
            {
                if (value != _isEnabledNext)
                {
                    _isEnabledNext = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _confirmPassword { get; set; }
        public string ConfirmPassword
        {
            get
            {
                return this._confirmPassword;
            }
            set
            {
                if (value != _confirmPassword)
                {
                    _confirmPassword = value;
                    OnPropertyChanged();
                }
            }
        }

        // USER NAME
        private bool _isVisibleUserName { get; set; }
        public bool IsVisibleUserName
        {
            get
            {
                return this._isVisibleUserName;
            }
            set
            {
                if (value != _isVisibleUserName)
                {
                    _isVisibleUserName = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _placeholderUserName { get; set; }
        public string PlaceholderUserName
        {
            get
            {
                return this._placeholderUserName;
            }
            set
            {
                if (value != _placeholderUserName)
                {
                    _placeholderUserName = value;
                    OnPropertyChanged();
                }
            }
        }

        // FULL NAME
        private bool _isVisibleFullName { get; set; }
        public bool IsVisibleFullName
        {
            get
            {
                return this._isVisibleFullName;
            }
            set
            {
                if (value != _isVisibleFullName)
                {
                    _isVisibleFullName = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _placeholderFullName { get; set; }
        public string PlaceholderFullName
        {
            get
            {
                return this._placeholderFullName;
            }
            set
            {
                if (value != _placeholderFullName)
                {
                    _placeholderFullName = value;
                    OnPropertyChanged();
                }
            }
        }

        // EMAIL
        private bool _isVisibleEmail { get; set; }
        public bool IsVisibleEmail
        {
            get
            {
                return this._isVisibleEmail;
            }
            set
            {
                if (value != _isVisibleEmail)
                {
                    _isVisibleEmail = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _placeholderEmail { get; set; }
        public string PlaceholderEmail
        {
            get
            {
                return this._placeholderEmail;
            }
            set
            {
                if (value != _placeholderEmail)
                {
                    _placeholderEmail = value;
                    OnPropertyChanged();
                }
            }
        }

        //PASSWORD
        private bool _isVisiblePassword { get; set; }
        public bool IsVisiblePassword
        {
            get
            {
                return this._isVisiblePassword;
            }
            set
            {
                if (value != _isVisiblePassword)
                {
                    _isVisiblePassword = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _placeholderPassword { get; set; }
        public string PlaceholderPassword
        {
            get
            {
                return this._placeholderPassword;
            }
            set
            {
                if (value != _placeholderPassword)
                {
                    _placeholderPassword = value;
                    OnPropertyChanged();
                }
            }
        }

        // CONFIRM PASSWORD
        private bool _isVisibleConfirmPass{ get; set; }
        public bool IsVisibleConfirmPass
        {
            get
            {
                return this._isVisibleConfirmPass;
            }
            set
            {
                if (value != _isVisibleConfirmPass)
                {
                    _isVisibleConfirmPass = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _placeholderConfirmPass { get; set; }
        public string PlaceholderConfirmPass
        {
            get
            {
                return this._placeholderConfirmPass;
            }
            set
            {
                if (value != _placeholderConfirmPass)
                {
                    _placeholderConfirmPass = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Properties
        public ICommand CommandNext { get { return new RelayCommand(NextC); } }

        public ICommand CommandEntryFocus { get { return new RelayCommand<string>(EntryFocusC); } }

        public ICommand CommandEntryUnFocus { get { return new RelayCommand<string>(EntryUnFocusC); } }

        public ICommand CommandEntryText { get { return new RelayCommand<string>(EntryTextC); } }

        public ICommand CommandEmailValidator { get { return new RelayCommand<bool>(EmailValidatorC); } }

        public ICommand CommandBack { get { return new RelayCommand(BackC); } }
        #endregion

        #region Builders
        public CreateAccountViewModel()
        {
            InitialData();
        }
        #endregion

        #region Commands
        void NextC()
        {
            switch (_carouselPosition)
            {
                case 0:
                    CarouselPosition = 1;
                    IsEnabledNext = false;
                    break;
                case 1:
                    CarouselPosition = 2;
                    IsEnabledNext = false;
                    break;
                case 2:

                    break;
                default:
                    CarouselPosition = 0;
                    break;
            }
        }

        void BackC()
        {
            switch (_carouselPosition)
            {
                case 2:
                    CarouselPosition = 1;
                    break;
                case 1:
                    CarouselPosition = 0;
                    break;
                default:
                    CarouselPosition = 0;
                    break;
            }
        }

        private void EntryFocusC(string obj)
        {
            switch (obj)
            {
                //USER NAME
                case "UserName":
                    if(string.IsNullOrWhiteSpace(_user.UserName))
                    {
                        IsVisibleUserName = true;
                        PlaceholderUserName = string.Empty;
                    }
                    break;

                //FULL NAME
                case "FullName":
                    if(string.IsNullOrWhiteSpace(_person.FullName))
                    {
                        IsVisibleFullName = true;
                        PlaceholderFullName = string.Empty;
                    }
                    break;

                //EMAIL
                case "Email":
                    if (string.IsNullOrWhiteSpace(_person.Email))
                    {
                        IsVisibleEmail = true;
                        PlaceholderEmail = string.Empty;
                    }
                    break;

                //PASSWORD
                case "Password":
                    if (string.IsNullOrWhiteSpace(_user.Password))
                    {
                        IsVisiblePassword = true;
                        PlaceholderPassword = string.Empty;
                    }
                    break;

                //CONFIRM PASSWORD
                case "ConfirmPass":
                    if(string.IsNullOrWhiteSpace(_confirmPassword))
                    {
                        IsVisibleConfirmPass = true;
                        PlaceholderConfirmPass = string.Empty;
                    }
                    break;
                default:
                    break;
            }
        }

        void EntryUnFocusC(string obj)
        {
            switch (obj)
            {
                //USER NAME
                case "UserName":
                    if (string.IsNullOrWhiteSpace(_user.UserName))
                    {
                        IsVisibleUserName = false;
                        PlaceholderUserName = "Nombre de usuario";
                    }
                    break;

                //FULL NAME
                case "FullName":
                    if(string.IsNullOrWhiteSpace(_person.FullName))
                    {
                        IsVisibleFullName = false;
                        PlaceholderFullName = "Nombre completo";
                    }
                    break;

                //EMAIL
                case "Email":
                    if (string.IsNullOrWhiteSpace(_person.Email))
                    {
                        IsVisibleEmail = false;
                        PlaceholderEmail = "Email";
                    }
                    break;

                //PASSWORD
                case "Password":
                    if(string.IsNullOrWhiteSpace(_user.Password))
                    {
                        IsVisiblePassword = false;
                        PlaceholderPassword = "Contraseña";
                    }
                    break;

                //CONFIRM PASSWORD
                case "ConfirmPass":
                    if (string.IsNullOrWhiteSpace(_confirmPassword))
                    {
                        IsVisibleConfirmPass = false;
                        PlaceholderConfirmPass = "Confirmar contraseña";
                    }
                    break;
                default:
                    break;
            }
        }

        void EntryTextC(string obj)
        {
            switch (obj)
            {
                //CREATE NOW USER
                case "NowUser":
                    if (!string.IsNullOrWhiteSpace(_user.UserName))
                    {
                        IsEnabledNext = true;
                    }
                    break;

                //CREATE NOW PERSON
                case "NowPerson":
                    if(!string.IsNullOrWhiteSpace(_person.FullName) 
                       && !string.IsNullOrWhiteSpace(_person.Email))
                    {
                        IsEnabledNext = true;
                    }
                    break;

                //CREATE PASSWORDS VIEW
                case "NowPassword":
                    if(!string.IsNullOrWhiteSpace(_user.Password)
                        && !string.IsNullOrWhiteSpace(_confirmPassword))
                    {
                        IsEnabledNext = true;
                    }
                    break;
                default:
                    break;
            }
        }

        void EmailValidatorC(bool obj)
        {
            if(obj)
            {
                SourceImage = "ic_check_circle_primary.png";
            }
            else
            {
                SourceImage = "ic_cancel_circle_primary.png";
            }
        }
        #endregion

        #region Methods
        void InitialData()
        {
            User = new User();
            Person = new Person();
            CarouselPosition = 0;
            IsEnabledNext = false;

            // USER NAME
            PlaceholderUserName = "Nombre de usuario";
            IsVisibleUserName = false;

            // FULL NAME
            PlaceholderFullName = "Nombre completo";
            IsVisibleFullName = false;

            // EMAIL
            PlaceholderEmail = "Email";
            IsVisibleEmail = false;

            // PASSWORD
            PlaceholderPassword = "Contraseña";
            IsVisiblePassword = false;

            // CONFIRM PASSWORD
            PlaceholderConfirmPass = "Confirmar contraseña;";
            IsVisibleConfirmPass = false;
        }

        void CheckUser()
        {
            if (!string.IsNullOrWhiteSpace(_user.UserName))
                IsEnabledNext = true;
            else
                IsEnabledNext = false;
        }

        void CheckPerson()
        {
            if(!string.IsNullOrWhiteSpace(_person.FullName) 
                && !string.IsNullOrWhiteSpace(_person.Email))
            {
                IsEnabledNext = true;
            }
        }
        #endregion
    }
}
