using GalaSoft.MvvmLight.Command;
using OnymousXamarin.Models;
using System.Windows.Input;

namespace OnymousXamarin.ViewModels
{
    public class RegisterViewModel : BaseViewModel
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
        public ICommand CommandClear { get { return new RelayCommand(ClearC); } }

        public ICommand CommandAccept { get { return new RelayCommand(AcceptC); } }

        public ICommand CommandReturnLogin { get { return new RelayCommand(ReturnLoginC); } }
        #endregion

        #region Builders
        public RegisterViewModel()
        {
            InitialData();
        }
        #endregion

        #region Commands
        void ClearC()
        {

        }

        void AcceptC()
        {

        }

        void ReturnLoginC()
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
