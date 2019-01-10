using GalaSoft.MvvmLight.Command;
using OnymousMobile.Models;
using System.Windows.Input;

namespace OnymousMobile.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {
        #region Attributes
        private Person _person { get; set; }
        public Person Person
        {
            get
            {
                return this._person;
            }
            set
            {
                if(value != _person)
                {
                    _person = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Properties
        public ICommand CommandPhoto{ get { return new RelayCommand(PhotoC); } }

        public ICommand CommandPersonName { get { return new RelayCommand(PersonNameC); } }

        public ICommand CommandConfiguration { get { return new RelayCommand(ConfigurationC); } }

        public ICommand CommandSignOff { get { return new RelayCommand(SignOffC); } }
        #endregion

        #region Builders
        public ProfileViewModel()
        {
            InitialData();
        }
        #endregion

        #region Commands
        //Cambiar foto de la persona
        void PhotoC()
        {

        }

        //Cambiar nombre de la persona
        void PersonNameC()
        {

        }

        //Configuracion de la cuenta
        void ConfigurationC()
        {

        }

        //Cerrar sesion
        void SignOffC()
        {

        }
        #endregion

        #region Methods
        void InitialData()
        {
            Person = new Person();
        }
        #endregion
    }
}
